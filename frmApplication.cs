using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_02
{
    public partial class frmApplication : Form
    {
        public frmApplication()
        {
            InitializeComponent();
        }

        private void btnSubApp_Click(object sender, EventArgs e)
        {
            string name = txtFName.Text;
            int phoneNumber = int.Parse(txtPNum.Text);
            string email = txtEmail.Text;
            string idNumber = txtIdNum.Text;


            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber.ToString()) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(idNumber))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            MessageBox.Show("Application submitted successfully!");

            if(cmbFlatName.SelectedItem != null)
            {
                string selectedFlat = cmbFlatName.SelectedItem.ToString();
                MessageBox.Show($"You have applied for the flat: {selectedFlat}");
            }
            else
            {
                MessageBox.Show("Please select a flat from the dropdown.");
            }
            string flatName = cmbFlatName.SelectedItem.ToString();
            if(flatName == "FAT01A")
            {
                lstOtput.Items.Add("Flat No: FAT01A \n Location : Durban \n Rooms :2 \n Rent: R5400 \n Availability: Available \n Action: Go to Apply for flat to do any action\r\n");
            }
            else if (flatName == "FAT02B")
            {
                lstOtput.Items.Add("Flat No: FAT02B \r\n Location : Durban\r\n Rooms : 1\r\n Rent: R4700\r\n Availability: Available\r\n Action: Go to Apply for flat to do any action\r\n");
            }
            else if (flatName == "FAT03A")
            {
                lstOtput.Items.Add("Flat No: FAT03A\r\nLocation : Durban\r\nRooms : 2\r\nRent: R5850\r\nAvailability: Not Available\r\nAction: Go to Apply for flat to do any action\r\n");
            }
            else if (flatName == "FAT04B")
            {
                lstOtput.Items.Add("Flat No: FAT04B\r\nLocation : Durban\r\nRooms : 2\r\nRent: R5400\r\nAvailability: Available\r\nAction: Go to Apply for flat to do any action\r\n");
            }



            string purpose=cmbResonApp.SelectedItem.ToString();
            string reasonForApplication = "";
            if (purpose == "Personal Use")
            {
                reasonForApplication = "Personal Use";
            }
            else if (purpose == "Home Office")
            {
                reasonForApplication = "Home Office";
            }
            
        }

        private void btnBackTTM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}


