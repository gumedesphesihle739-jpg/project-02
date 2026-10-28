namespace project_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForgot = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreatAcc
            // 
            this.btnCreatAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatAcc.Location = new System.Drawing.Point(607, 585);
            this.btnCreatAcc.Name = "btnCreatAcc";
            this.btnCreatAcc.Size = new System.Drawing.Size(247, 48);
            this.btnCreatAcc.TabIndex = 0;
            this.btnCreatAcc.Text = "Create Account";
            this.btnCreatAcc.UseVisualStyleBackColor = false;
            this.btnCreatAcc.Click += new System.EventHandler(this.btnCreatAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(168, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username:";
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(173, 236);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUser_name.Size = new System.Drawing.Size(364, 30);
            this.txtUser_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to Reside Care";
            // 
            // btnForgot
            // 
            this.btnForgot.BackColor = System.Drawing.Color.Transparent;
            this.btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgot.Location = new System.Drawing.Point(173, 585);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(338, 47);
            this.btnForgot.TabIndex = 4;
            this.btnForgot.Text = "Forgot Password";
            this.btnForgot.UseVisualStyleBackColor = false;
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(173, 472);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(338, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(168, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(173, 365);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(364, 30);
            this.txtPass.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatAcc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
    }
}

