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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void btnCreatAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void btnForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser_name.Text.Trim();
            string password = txtPass.Text;

            string filePath =
                @"C:\Users\gumed\Downloads\DocumentProj.txt";

            // Check whether the fields are empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            // Check whether the account file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    "The account file could not be found. Please create an account first.");
                return;
            }

            bool loginSuccessful = false;

            try
            {
                // Read the account information
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] readFile = line.Split(',');

                        // Check the username and actual password
                        if (readFile.Length > 10 &&
                            readFile[10].Trim() == username &&
                            readFile[5] == password)
                        {
                            loginSuccessful = true;
                            break;
                        }
                    }
                }

                if (loginSuccessful)
                {
                    MessageBox.Show("Login Successful");

                    this.Hide();

                    Form4 form4 = (Form4)Activator.CreateInstance(typeof(Form4));
                    form4.ShowDialog();
                    form4.Dispose();

                    // Show the login form again when Form4 closes
                    this.Show();

                    // Clear the login fields
                    txtUser_name.Clear();
                    txtPass.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "An error occurred while reading the account file.");
            }
        }

        
    }
}
