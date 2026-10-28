using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace project_02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //declaration of variables
            string name = txtName.Text;
            string lastName = txtLName.Text;
            string address = txtPAddress.Text;
            string phone = txtCellNum.Text;
            string email = txtEmail.Text;
            string creatPassword = txtCpass.Text;
            string confirmPassword = txtVPass.Text;

            string province = cmbProvince.SelectedItem.ToString();  

            
            string gender = "";
            //selection of the gender using the raidio button
            if (radMale.Checked)  
            {
                gender = "Male";

            }
            else if (radFemale.Checked)
            {
                gender = "Female";
            }
            else if (radOther.Checked)
            {
                gender = "Other";
            }

            string occupation = txtOccupation.Text;
            string username = txtCreateUserName.Text;
            string pet =cmbPat.SelectedItem.ToString();


            //validation of the input fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(creatPassword) 
                || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(province) || string.IsNullOrWhiteSpace(gender)  )
            {
                                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if(creatPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Write the data to a text file
            StreamWriter obj = new StreamWriter(@"C:\Users\gumed\Downloads\DocumentProj.txt", true);
            obj.WriteLine(name + "," + lastName + "," + address + "," + phone + "," + email + "," + creatPassword + "," 
                + confirmPassword + "," + province + "," + gender + "," + occupation + "," + username + "," + pet);
            obj.Close();

            // Clear the input fields after successful account creation
            txtCellNum.Clear();
            txtCpass.Clear();
            txtCreateUserName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            txtName.Clear();
            txtOccupation.Clear();
           txtCreateUserName.Clear();
            txtPAddress.Clear();
            txtVPass.Clear();
            cmbProvince.SelectedIndex = -1;// Clear the selected index of the combo box
            cmbPat.SelectedIndex = -1;
            radMale.Checked = false;
            radFemale.Checked = false;
            radOther.Checked = false;

            // Show a success message
            MessageBox.Show("Account created successfully!"); return;

        }


        //back button to go back to the login page
        private void btnBack_Click(object sender, EventArgs e)
        {

            // Hide the current form and show Form1(login form)
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        
    }

}
        
