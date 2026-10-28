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
    public partial class frmSeachAndViewFlat : Form
    {
        public frmSeachAndViewFlat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtSeach.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            if (searchText == "FAT01A")
            {
                picRoom2.Hide();
                picRoom3.Hide();
                picRoom4.Hide();
                lblDescRoom2.Hide();
                lblDescRoom3.Hide();
                lblDescRoom4.Hide();
            }
            else if (searchText == "FAT02B")
            {
                picRoom1.Hide();
                picRoom3.Hide();
                picRoom4.Hide();
                lblDescRoom1.Hide();
                lblDescRoom3.Hide();
                lblDescRoom4.Hide();
            }
            else if (searchText == "FAT03A")
            {
                picRoom1.Hide();
                picRoom2.Hide();
                picRoom4.Hide();
                lblDescRoom1.Hide();
                lblDescRoom2.Hide();
                lblDescRoom4.Hide();
            }
            else if (searchText == "FAT04B")
            {
                picRoom1.Hide();
                picRoom2.Hide();
                picRoom3.Hide();
                lblDescRoom1.Hide();
                lblDescRoom2.Hide();
                lblDescRoom3.Hide();
            }
            else
            {
                MessageBox.Show("No matching flat found.");
            }
        }

        private void btnBackTTM_Click(object sender, EventArgs e)
        {
              this.Hide();
            Form4 form = new Form4();
            form.ShowDialog();
            form.Show();

        }

    }
}
