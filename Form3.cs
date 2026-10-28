using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            
            string userName = txtPassUsername.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();
            string confirmNewPassword = txtVerNewPass.Text.Trim();

            //Opening the file/textfile to access the information inside it
            string filePath = @"C:\Users\gumed\Downloads\DocumentProj.txt";
            

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("The passwords do not match.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            bool userFound = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                if (data.Length > 11 && data[10].Trim() == userName && data[11]==cmbPetVarification.SelectedItem.ToString())
                    //The user is only allowed to change the password only if the username and favorite pet matches with the one on the textfile
                {
                    data[5] = newPassword;
                    data[6] = confirmNewPassword;

                    lines[i] = string.Join(",", data); //puting the new password on the text file

                    userFound = true;
                    break;
                }
            }
            //Show this message if the user's password is successfully changed
            if (userFound)
            {
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Password changed successfully.");
            }
            else
            {
                MessageBox.Show("Username not found.");
            }
        }

        private void btnBackToLog_Click(object sender, EventArgs e)  
        {
            //hide form3 and opening form 1 (login form)
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

