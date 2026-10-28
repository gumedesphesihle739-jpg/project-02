namespace project_02
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassUsername = new System.Windows.Forms.TextBox();
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnBackToLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPetVarification = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username:";
            // 
            // txtPassUsername
            // 
            this.txtPassUsername.Location = new System.Drawing.Point(412, 174);
            this.txtPassUsername.Name = "txtPassUsername";
            this.txtPassUsername.Size = new System.Drawing.Size(321, 30);
            this.txtPassUsername.TabIndex = 1;
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Location = new System.Drawing.Point(412, 574);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(363, 49);
            this.btnCreatePass.TabIndex = 2;
            this.btnCreatePass.Text = "Create Password";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verify The Password:";
            // 
            // txtVerNewPass
            // 
            this.txtVerNewPass.Location = new System.Drawing.Point(412, 466);
            this.txtVerNewPass.Name = "txtVerNewPass";
            this.txtVerNewPass.Size = new System.Drawing.Size(312, 30);
            this.txtVerNewPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(412, 317);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(312, 30);
            this.txtNewPass.TabIndex = 6;
            // 
            // btnBackToLog
            // 
            this.btnBackToLog.Location = new System.Drawing.Point(861, 574);
            this.btnBackToLog.Name = "btnBackToLog";
            this.btnBackToLog.Size = new System.Drawing.Size(363, 49);
            this.btnBackToLog.TabIndex = 7;
            this.btnBackToLog.Text = "Back To Login";
            this.btnBackToLog.UseVisualStyleBackColor = true;
            this.btnBackToLog.Click += new System.EventHandler(this.btnBackToLog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "What your favourity pet?";
            // 
            // cmbPetVarification
            // 
            this.cmbPetVarification.FormattingEnabled = true;
            this.cmbPetVarification.Items.AddRange(new object[] {
            "dogs ",
            "cats",
            " birds",
            " fish",
            " small mammals",
            " reptiles",
            " amphibians"});
            this.cmbPetVarification.Location = new System.Drawing.Point(935, 179);
            this.cmbPetVarification.Name = "cmbPetVarification";
            this.cmbPetVarification.Size = new System.Drawing.Size(271, 33);
            this.cmbPetVarification.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.cmbPetVarification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackToLog);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtVerNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreatePass);
            this.Controls.Add(this.txtPassUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassUsername;
        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnBackToLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPetVarification;
    }
}