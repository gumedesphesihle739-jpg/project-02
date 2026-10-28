using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_02
{
    public partial class Form4 : Form
    {
        // Main colours used in the application
        Color darkBlue = Color.FromArgb(12, 43, 78);
        Color lightBackground = Color.FromArgb(245, 248, 253);
        Color textBlue = Color.FromArgb(12, 43, 100);

        

        private void CreateForm4()
        {
            // Form settings
            this.Text = "Residential Administration System";
            this.Size = new Size(1250, 850);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = lightBackground;
            this.MinimumSize = new Size(1000, 700);

            // Remove existing controls from the form
            // so that the menu is not duplicated.
            this.Controls.Clear();

            // =====================================
            // SIDEBAR
            // =====================================

            Panel pnlSidebar = new Panel();

            pnlSidebar.Size = new Size(250, 850);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.BackColor = darkBlue;
            pnlSidebar.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            this.Controls.Add(pnlSidebar);

            // Application title
            Label lblTitle = new Label();

            lblTitle.Text = "⌂\nResidential\nAdministration\nSystem";
            lblTitle.Font = new Font("Arial", 19, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Size = new Size(230, 155);
            lblTitle.Location = new Point(10, 15);

            pnlSidebar.Controls.Add(lblTitle);

            // Sidebar buttons
            Button btnTenantMenu = CreateSidebarButton(
                "Tenant Menu", 15, 200);

            Button btnLogout = CreateSidebarButton(
                "Logout", 15, 265);

            Button btnExit = CreateSidebarButton(
                "Exit", 15, 330);

            pnlSidebar.Controls.Add(btnTenantMenu);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnExit);

            // Sidebar slogan
            Label lblSlogan = new Label();

            lblSlogan.Text = "Your Home,\nOur Priority.";
            lblSlogan.Font = new Font(
                "Arial", 18, FontStyle.Italic);

            lblSlogan.ForeColor = Color.White;
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            lblSlogan.Size = new Size(230, 100);
            lblSlogan.Location = new Point(10, 620);
            lblSlogan.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            pnlSidebar.Controls.Add(lblSlogan);

            // =====================================
            // MAIN CONTENT
            // =====================================

            Panel pnlMain = new Panel();

            pnlMain.Location = new Point(250, 0);
            pnlMain.Size = new Size(980, 850);
            pnlMain.BackColor = lightBackground;
            pnlMain.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.Controls.Add(pnlMain);

            // Welcome heading
            Label lblWelcome = new Label();

            lblWelcome.Text = "Welcome to Your Tenant Menu!";
            lblWelcome.Font = new Font(
                "Arial", 23, FontStyle.Bold);

            lblWelcome.ForeColor = textBlue;
            lblWelcome.Location = new Point(30, 35);
            lblWelcome.Size = new Size(850, 45);

            pnlMain.Controls.Add(lblWelcome);

            // Description
            Label lblDescription = new Label();

            lblDescription.Text =
                "Manage your account, search for flats and track applications.";

            lblDescription.Font = new Font("Arial", 12);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(32, 85);
            lblDescription.Size = new Size(850, 35);

            pnlMain.Controls.Add(lblDescription);

            // =====================================
            // MENU CARDS
            // =====================================

            Button btnMyProfile = CreateMenuCard(
                "My Profile",
                "View or update your\npersonal information.",
                Color.RoyalBlue);

            btnMyProfile.Location = new Point(30, 150);

            Button btnSearchFlats = CreateMenuCard(
                "Search Flats",
                "Find available flats\nthat match your needs.",
                Color.SeaGreen);

            btnSearchFlats.Location = new Point(345, 150);

            Button btnApplyForFlat = CreateMenuCard(
                "Apply for a Flat",
                "Submit an application\nfor a selected flat.",
                Color.DarkOrange);

            btnApplyForFlat.Location = new Point(660, 150);

            Button btnMyApplications = CreateMenuCard(
                "My Applications",
                "Track the status of\nyour applications.",
                Color.MediumPurple);

            btnMyApplications.Location = new Point(30, 295);

            Button btnResetPassword = CreateMenuCard(
                "Reset Password",
                "Change your password\nfor a secure account.",
                Color.Teal);

            btnResetPassword.Location = new Point(345, 295);

            Button btnPayments = CreateMenuCard(
                "Payments",
                "View balances and\npayment history.",
                Color.Crimson);

            btnPayments.Location = new Point(660, 295);

            pnlMain.Controls.Add(btnMyProfile);
            pnlMain.Controls.Add(btnSearchFlats);
            pnlMain.Controls.Add(btnApplyForFlat);
            pnlMain.Controls.Add(btnMyApplications);
            pnlMain.Controls.Add(btnResetPassword);
            pnlMain.Controls.Add(btnPayments);

            // =====================================
            // PROPERTY BANNER
            // =====================================

            Panel pnlBanner = new Panel();

            pnlBanner.Size = new Size(920, 200);
            pnlBanner.Location = new Point(30, 455);
            pnlBanner.BackColor = Color.FromArgb(220, 233, 248);
            pnlBanner.BorderStyle = BorderStyle.FixedSingle;

            pnlMain.Controls.Add(pnlBanner);

            Label lblPropertyTitle = new Label();

            lblPropertyTitle.Text = "RESIDENTIAL LIVING";
            lblPropertyTitle.Font = new Font(
                "Arial", 22, FontStyle.Bold);

            lblPropertyTitle.ForeColor = darkBlue;
            lblPropertyTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblPropertyTitle.Size = new Size(450, 50);
            lblPropertyTitle.Location = new Point(20, 35);

            pnlBanner.Controls.Add(lblPropertyTitle);

            Label lblPropertyDescription = new Label();

            lblPropertyDescription.Text =
                "Find a place to call home.\n" +
                "Comfort, convenience and security.";

            lblPropertyDescription.Font = new Font("Arial", 14);
            lblPropertyDescription.ForeColor = textBlue;
            lblPropertyDescription.TextAlign =
                ContentAlignment.MiddleCenter;

            lblPropertyDescription.Size = new Size(450, 65);
            lblPropertyDescription.Location = new Point(20, 90);

            pnlBanner.Controls.Add(lblPropertyDescription);

            Label lblSafe = new Label();

            lblSafe.Text = "Safe. Secure.\nComfortable.";
            lblSafe.Font = new Font(
                "Arial", 20, FontStyle.Bold);

            lblSafe.ForeColor = Color.White;
            lblSafe.BackColor = darkBlue;
            lblSafe.TextAlign = ContentAlignment.MiddleCenter;
            lblSafe.Size = new Size(400, 198);
            lblSafe.Location = new Point(518, 0);

            pnlBanner.Controls.Add(lblSafe);

            // =====================================
            // FOOTER
            // =====================================

            Label lblFooter = new Label();

            lblFooter.Text =
                "Residential Administration System | Tenant Portal";

            lblFooter.Font = new Font("Arial", 10);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            lblFooter.Size = new Size(920, 30);
            lblFooter.Location = new Point(30, 680);

            pnlMain.Controls.Add(lblFooter);

            // =====================================
            // BUTTON EVENTS
            // =====================================

            btnTenantMenu.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "You are already on the Tenant Menu.");
            };

            btnMyProfile.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "My Profile selected.");
            };

            btnSearchFlats.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "Search Flats selected.");
            };

            btnApplyForFlat.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "Apply for a Flat selected.");
            };

            btnMyApplications.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "My Applications selected.");
            };

            btnResetPassword.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "Reset Password selected.");
            };

            btnPayments.Click += (sender, e) =>
            {
                MessageBox.Show(
                    "Payments selected.");
            };

            btnLogout.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            btnExit.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
        }

        // =====================================
        // METHOD TO CREATE SIDEBAR BUTTONS
        // =====================================

        private Button CreateSidebarButton(
            string buttonText, int x, int y)
        {
            Button btn = new Button();

            btn.Text = buttonText;
            btn.Size = new Size(220, 50);
            btn.Location = new Point(x, y);

            btn.BackColor = darkBlue;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Arial", 12, FontStyle.Bold);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);

            return btn;
        }

        // =====================================
        // METHOD TO CREATE MENU CARDS
        // =====================================

        private Button CreateMenuCard(
            string title, string description, Color accentColor)
        {
            Button btn = new Button();

            btn.Size = new Size(290, 125);
            btn.BackColor = Color.White;
            btn.ForeColor = textBlue;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor =
                Color.FromArgb(210, 225, 245);

            btn.FlatAppearance.BorderSize = 1;

            btn.Font = new Font("Arial", 13, FontStyle.Bold);

            btn.Text = title + "\n\n" + description;

            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 5, 5, 5);

            // Add a coloured line at the left of the card.
            btn.Paint += (sender, e) =>
            {
                using (SolidBrush brush =
                    new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(
                        brush, 0, 0, 7, btn.Height);
                }
            };

            return btn;
        }

        // This is a minimal stub for InitializeComponent,
        // since your form is built entirely in code.
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTenentMenu = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnSearchFlats = new System.Windows.Forms.Button();
            this.btnMyApplication = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnApplyForFlat = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(13, 365);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 50);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnTenentMenu
            // 
            this.btnTenentMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTenentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenentMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenentMenu.Location = new System.Drawing.Point(13, 263);
            this.btnTenentMenu.Name = "btnTenentMenu";
            this.btnTenentMenu.Size = new System.Drawing.Size(220, 50);
            this.btnTenentMenu.TabIndex = 2;
            this.btnTenentMenu.Text = "Tenent Menu";
            this.btnTenentMenu.UseVisualStyleBackColor = false;
            this.btnTenentMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.lblText);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.btnLogOut);
            this.pnlSidebar.Controls.Add(this.btnTenentMenu);
            this.pnlSidebar.ForeColor = System.Drawing.Color.White;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(250, 810);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 772);
            this.pnlSidebar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(34, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 119);
            this.label2.TabIndex = 14;
            this.label2.Text = "Your Home, Our Priority.\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.DarkBlue;
            this.lblText.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(6, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(240, 219);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Residential Adiministration System";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(283, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(850, 50);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to Your Tenant Menu!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(409, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(606, 35);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Manage your account, search for flats and track applictions.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.White;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnResetPassword.Location = new System.Drawing.Point(531, 411);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(220, 180);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnSearchFlats
            // 
            this.btnSearchFlats.BackColor = System.Drawing.Color.White;
            this.btnSearchFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFlats.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlats.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchFlats.Location = new System.Drawing.Point(531, 213);
            this.btnSearchFlats.Name = "btnSearchFlats";
            this.btnSearchFlats.Size = new System.Drawing.Size(220, 180);
            this.btnSearchFlats.TabIndex = 7;
            this.btnSearchFlats.Text = "Search Flats";
            this.btnSearchFlats.UseVisualStyleBackColor = false;
            this.btnSearchFlats.Click += new System.EventHandler(this.btnSearchFlats_Click);
            // 
            // btnMyApplication
            // 
            this.btnMyApplication.BackColor = System.Drawing.Color.White;
            this.btnMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplication.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyApplication.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMyApplication.Location = new System.Drawing.Point(291, 411);
            this.btnMyApplication.Name = "btnMyApplication";
            this.btnMyApplication.Size = new System.Drawing.Size(220, 180);
            this.btnMyApplication.TabIndex = 8;
            this.btnMyApplication.Text = "My Applications";
            this.btnMyApplication.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProfile.Location = new System.Drawing.Point(291, 213);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 180);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "My profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnApplyForFlat
            // 
            this.btnApplyForFlat.BackColor = System.Drawing.Color.White;
            this.btnApplyForFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyForFlat.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyForFlat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplyForFlat.Location = new System.Drawing.Point(769, 213);
            this.btnApplyForFlat.Name = "btnApplyForFlat";
            this.btnApplyForFlat.Size = new System.Drawing.Size(220, 180);
            this.btnApplyForFlat.TabIndex = 10;
            this.btnApplyForFlat.Text = "Apply for a Flat";
            this.btnApplyForFlat.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.White;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnPayments.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPayments.Location = new System.Drawing.Point(769, 411);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(220, 180);
            this.btnPayments.TabIndex = 11;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(250, 597);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 231);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(256, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 119);
            this.label1.TabIndex = 13;
            this.label1.Text = "Safe. Secure. Comfortable.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1328, 770);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnApplyForFlat);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSearchFlats);
            this.Controls.Add(this.btnMyApplication);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Arial Narrow", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residential Administration System";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Button btnExit;
        private Button btnLogOut;
        private Button btnTenentMenu;
        private Panel pnlSidebar;
        private Label lblText;
        private Label lblWelcome;
        private Label lblDescription;
        private Button btnResetPassword;
        private Button btnSearchFlats;
        private Button btnMyApplication;
        private Button btnProfile;
        private Button btnApplyForFlat;
        private Button btnPayments;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
