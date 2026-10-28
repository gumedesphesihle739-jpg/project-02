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
    public partial class Form4 : Form
    {
        public Form4()
        {


            InitializeComponent();

        }



        private void CreateProfile()
        {
            // Remove the old profile if it already exists
            Control oldProfile = this.Controls["pnlProfile"];

            if (oldProfile != null)
            {
                this.Controls.Remove(oldProfile);
                oldProfile.Dispose();
            }

            // MAIN PROFILE AREA

            Panel pnlProfile = new Panel();

            pnlProfile.Name = "pnlProfile";
            pnlProfile.Tag = "Dynamic";
            pnlProfile.Location = new Point(250, 0);
            pnlProfile.Size = new Size(
                this.ClientSize.Width - 250,
                this.ClientSize.Height
            );

            pnlProfile.Anchor = AnchorStyles.Top |
                                AnchorStyles.Bottom |
                                AnchorStyles.Left |
                                AnchorStyles.Right;

            pnlProfile.BackColor = Color.FromArgb(240, 246, 253);
            pnlProfile.AutoScroll = true;

            this.Controls.Add(pnlProfile);
            pnlProfile.BringToFront();

            // PROFILE HEADING 

            Label lblTitle = new Label();

            lblTitle.Text = "MY PROFILE";
            lblTitle.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 55, 100);
            lblTitle.Location = new Point(30, 25);
            lblTitle.AutoSize = true;

            pnlProfile.Controls.Add(lblTitle);

            // Subtitle
            Label lblSubtitle = new Label();

            lblSubtitle.Text =
                "View and manage your personal information.";

            lblSubtitle.Font = new Font("Segoe UI", 11);
            lblSubtitle.ForeColor = Color.FromArgb(95, 120, 150);
            lblSubtitle.Location = new Point(32, 75);
            lblSubtitle.AutoSize = true;

            pnlProfile.Controls.Add(lblSubtitle);

            // PERSONAL INFORMATION CARD 

            Panel pnlInformation = new Panel();

            pnlInformation.Name = "pnlInformation";
            pnlInformation.Location = new Point(30, 120);
            pnlInformation.Size = new Size(
                pnlProfile.ClientSize.Width - 60,
                440
            );

            pnlInformation.Anchor = AnchorStyles.Top |
                                    AnchorStyles.Left |
                                    AnchorStyles.Right;

            pnlInformation.BackColor = Color.White;
            pnlInformation.BorderStyle = BorderStyle.None;

            // Draw the light-blue border
            pnlInformation.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(
                    Color.FromArgb(195, 220, 250), 1))
                {
                    e.Graphics.DrawRectangle(
                        borderPen,
                        0,
                        0,
                        pnlInformation.Width - 1,
                        pnlInformation.Height - 1
                    );
                }
            };

            pnlProfile.Controls.Add(pnlInformation);




            // READ TENANT INFORMATION 

            string filePath =
                @"C:\Users\gumed\Downloads\DocumentProj.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    "Tenant information file was not found."
                );

                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data.Length >= 12)
                {
                    string[,] details =
                    {
                { "First Name:", data[0] },
                { "Last Name:", data[1] },
                { "Address:", data[2] },
                { "Phone:", data[3] },
                { "Email:", data[4] },
                { "Province:", data[7] },
                { "Gender:", data[8] },
                { "Occupation:", data[9] },
                { "Username:", data[10] }
            };

                    int startY = 65;
                    int rowHeight = 39;

                    // TENANT DETAILS

                    for (int i = 0; i < details.GetLength(0); i++)
                    {
                        // Detail name
                        Label lblName = new Label();

                        lblName.Text = details[i, 0];

                        lblName.Font =
                            new Font("Segoe UI", 10);

                        lblName.ForeColor =
                            Color.FromArgb(95, 120, 150);

                        lblName.Location = new Point(
                            22,
                            startY + (i * rowHeight)
                        );

                        lblName.Size = new Size(200, 30);

                        pnlInformation.Controls.Add(lblName);

                        // Detail value
                        Label lblValue = new Label();

                        lblValue.Text = details[i, 1];

                        lblValue.Font =
                            new Font("Segoe UI", 10);

                        lblValue.ForeColor =
                            Color.FromArgb(20, 50, 85);

                        lblValue.Location = new Point(
                            230,
                            startY + (i * rowHeight)
                        );

                        lblValue.Size = new Size(
                            pnlInformation.ClientSize.Width - 250,
                            30
                        );

                        lblValue.Anchor = AnchorStyles.Top |
                                          AnchorStyles.Left |
                                          AnchorStyles.Right;

                        pnlInformation.Controls.Add(lblValue);

                        // HORIZONTAL SEPARATOR 

                        if (i < details.GetLength(0) - 1)
                        {
                            Panel linePanel = new Panel();

                            linePanel.BackColor =
                                Color.FromArgb(225, 235, 245);

                            linePanel.Location = new Point(
                                22,
                                startY + (i * rowHeight) + 30
                            );

                            linePanel.Size = new Size(
                                pnlInformation.ClientSize.Width - 45,
                                1
                            );

                            linePanel.Anchor = AnchorStyles.Top |
                                               AnchorStyles.Left |
                                               AnchorStyles.Right;

                            pnlInformation.Controls.Add(linePanel);
                        }
                    }

                    return;
                }
            }

            MessageBox.Show(
                "No tenant information was found."
            );
        }





        private void btnProfile_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Profile button clicked!");
            // Display the profile
            CreateProfile();
        }


       



        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Remove all controls created dynamically
            foreach (Control control in this.Controls.Cast<Control>().ToList())
            {
                if (control.Tag != null && control.Tag.ToString() == "Dynamic")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Hide all other controls
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            // Bring back the six menu buttons
            btnProfile.Visible = true;
            btnSearchFlats.Visible = true;
            btnApplyForFlat.Visible = true;
            btnMyApplication.Visible = true;
            btnResetPassword.Visible = true;
            btnPayments.Visible = true;

            // Show the Tenant Menu button
            btnTenentMenu.Visible = true;

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        

  
private void btnSearchFlats_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeachAndViewFlat form = new frmSeachAndViewFlat();
            form.ShowDialog();

            
        }

    }

}



