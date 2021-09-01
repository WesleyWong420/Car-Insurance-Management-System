namespace Assignment_CYB
{
    partial class StaffMenu
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.acctypeTextLabel = new System.Windows.Forms.Label();
            this.staffIDTextLabel = new System.Windows.Forms.Label();
            this.staffnameTextLabel = new System.Windows.Forms.Label();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.existingRadioButton = new System.Windows.Forms.RadioButton();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.staffnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.multiButton = new System.Windows.Forms.Button();
            this.radiobuttonGroupBox = new System.Windows.Forms.GroupBox();
            this.staffScreenButton = new System.Windows.Forms.Button();
            this.customerScreenButton = new System.Windows.Forms.Button();
            this.insuranceScreenButton = new System.Windows.Forms.Button();
            this.homeScreenButton = new System.Windows.Forms.Button();
            this.radiobuttonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(38, 17);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(67, 17);
            this.lblStaffID.TabIndex = 11;
            this.lblStaffID.Text = "{staff_id}";
            this.lblStaffID.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(89, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(449, 30);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "CAR INSURANCE MANAGEMENT SYSTEM";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(567, 17);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(90, 17);
            this.lblStaffName.TabIndex = 14;
            this.lblStaffName.Text = "{staff_name}";
            this.lblStaffName.Visible = false;
            // 
            // acctypeTextLabel
            // 
            this.acctypeTextLabel.AutoSize = true;
            this.acctypeTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctypeTextLabel.Location = new System.Drawing.Point(91, 132);
            this.acctypeTextLabel.Name = "acctypeTextLabel";
            this.acctypeTextLabel.Size = new System.Drawing.Size(103, 17);
            this.acctypeTextLabel.TabIndex = 19;
            this.acctypeTextLabel.Text = "Account Type:";
            // 
            // staffIDTextLabel
            // 
            this.staffIDTextLabel.AutoSize = true;
            this.staffIDTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDTextLabel.Location = new System.Drawing.Point(91, 187);
            this.staffIDTextLabel.Name = "staffIDTextLabel";
            this.staffIDTextLabel.Size = new System.Drawing.Size(62, 17);
            this.staffIDTextLabel.TabIndex = 20;
            this.staffIDTextLabel.Text = "Staff ID:";
            // 
            // staffnameTextLabel
            // 
            this.staffnameTextLabel.AutoSize = true;
            this.staffnameTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnameTextLabel.Location = new System.Drawing.Point(91, 241);
            this.staffnameTextLabel.Name = "staffnameTextLabel";
            this.staffnameTextLabel.Size = new System.Drawing.Size(83, 17);
            this.staffnameTextLabel.TabIndex = 21;
            this.staffnameTextLabel.Text = "Staff Name:";
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.AutoSize = true;
            this.passwordTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextLabel.Location = new System.Drawing.Point(91, 299);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(75, 17);
            this.passwordTextLabel.TabIndex = 22;
            this.passwordTextLabel.Text = "Password:";
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Location = new System.Drawing.Point(5, 30);
            this.newRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(58, 21);
            this.newRadioButton.TabIndex = 0;
            this.newRadioButton.Text = "New";
            this.newRadioButton.UseVisualStyleBackColor = true;
            this.newRadioButton.CheckedChanged += new System.EventHandler(this.newRadioButton_CheckedChanged);
            // 
            // existingRadioButton
            // 
            this.existingRadioButton.AutoSize = true;
            this.existingRadioButton.Checked = true;
            this.existingRadioButton.Location = new System.Drawing.Point(77, 30);
            this.existingRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.existingRadioButton.Name = "existingRadioButton";
            this.existingRadioButton.Size = new System.Drawing.Size(83, 21);
            this.existingRadioButton.TabIndex = 1;
            this.existingRadioButton.TabStop = true;
            this.existingRadioButton.Text = "Existing";
            this.existingRadioButton.UseVisualStyleBackColor = true;
            this.existingRadioButton.CheckedChanged += new System.EventHandler(this.existingRadioButton_CheckedChanged);
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDTextBox.Location = new System.Drawing.Point(225, 187);
            this.staffIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.Size = new System.Drawing.Size(208, 25);
            this.staffIDTextBox.TabIndex = 0;
            // 
            // staffnameTextBox
            // 
            this.staffnameTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnameTextBox.Location = new System.Drawing.Point(225, 241);
            this.staffnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffnameTextBox.Name = "staffnameTextBox";
            this.staffnameTextBox.Size = new System.Drawing.Size(208, 25);
            this.staffnameTextBox.TabIndex = 1;
            this.staffnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffnameTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(225, 294);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(208, 25);
            this.passwordTextBox.TabIndex = 2;
            // 
            // multiButton
            // 
            this.multiButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiButton.Location = new System.Drawing.Point(269, 423);
            this.multiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(117, 49);
            this.multiButton.TabIndex = 3;
            this.multiButton.Text = "Login";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // radiobuttonGroupBox
            // 
            this.radiobuttonGroupBox.Controls.Add(this.newRadioButton);
            this.radiobuttonGroupBox.Controls.Add(this.existingRadioButton);
            this.radiobuttonGroupBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonGroupBox.Location = new System.Drawing.Point(225, 100);
            this.radiobuttonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobuttonGroupBox.Name = "radiobuttonGroupBox";
            this.radiobuttonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobuttonGroupBox.Size = new System.Drawing.Size(209, 59);
            this.radiobuttonGroupBox.TabIndex = 29;
            this.radiobuttonGroupBox.TabStop = false;
            // 
            // staffScreenButton
            // 
            this.staffScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_102327;
            this.staffScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staffScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffScreenButton.Location = new System.Drawing.Point(497, 513);
            this.staffScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffScreenButton.Name = "staffScreenButton";
            this.staffScreenButton.Size = new System.Drawing.Size(160, 117);
            this.staffScreenButton.TabIndex = 7;
            this.staffScreenButton.Text = "Staff";
            this.staffScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.staffScreenButton.UseVisualStyleBackColor = true;
            // 
            // customerScreenButton
            // 
            this.customerScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_103222;
            this.customerScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerScreenButton.Enabled = false;
            this.customerScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerScreenButton.Location = new System.Drawing.Point(332, 513);
            this.customerScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerScreenButton.Name = "customerScreenButton";
            this.customerScreenButton.Size = new System.Drawing.Size(160, 117);
            this.customerScreenButton.TabIndex = 6;
            this.customerScreenButton.Text = "Customer";
            this.customerScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerScreenButton.UseVisualStyleBackColor = true;
            this.customerScreenButton.Click += new System.EventHandler(this.customerScreenButton_Click);
            // 
            // insuranceScreenButton
            // 
            this.insuranceScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_104101;
            this.insuranceScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insuranceScreenButton.Enabled = false;
            this.insuranceScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceScreenButton.Location = new System.Drawing.Point(167, 513);
            this.insuranceScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceScreenButton.Name = "insuranceScreenButton";
            this.insuranceScreenButton.Size = new System.Drawing.Size(160, 117);
            this.insuranceScreenButton.TabIndex = 5;
            this.insuranceScreenButton.Text = "Insurance";
            this.insuranceScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insuranceScreenButton.UseVisualStyleBackColor = true;
            this.insuranceScreenButton.Click += new System.EventHandler(this.insuranceScreenButton_Click);
            // 
            // homeScreenButton
            // 
            this.homeScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_104445;
            this.homeScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.Location = new System.Drawing.Point(1, 513);
            this.homeScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeScreenButton.Name = "homeScreenButton";
            this.homeScreenButton.Size = new System.Drawing.Size(160, 117);
            this.homeScreenButton.TabIndex = 4;
            this.homeScreenButton.Text = "Home";
            this.homeScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeScreenButton.UseVisualStyleBackColor = true;
            this.homeScreenButton.Click += new System.EventHandler(this.homeScreenButton_Click);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(656, 629);
            this.Controls.Add(this.radiobuttonGroupBox);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.staffnameTextBox);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.passwordTextLabel);
            this.Controls.Add(this.staffnameTextLabel);
            this.Controls.Add(this.staffIDTextLabel);
            this.Controls.Add(this.acctypeTextLabel);
            this.Controls.Add(this.staffScreenButton);
            this.Controls.Add(this.customerScreenButton);
            this.Controls.Add(this.insuranceScreenButton);
            this.Controls.Add(this.homeScreenButton);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lblStaffID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.Load += new System.EventHandler(this.StaffMenu_Load);
            this.radiobuttonGroupBox.ResumeLayout(false);
            this.radiobuttonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button homeScreenButton;
        private System.Windows.Forms.Button insuranceScreenButton;
        private System.Windows.Forms.Button customerScreenButton;
        private System.Windows.Forms.Button staffScreenButton;
        private System.Windows.Forms.Label acctypeTextLabel;
        private System.Windows.Forms.Label staffIDTextLabel;
        private System.Windows.Forms.Label staffnameTextLabel;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.GroupBox radiobuttonGroupBox;
        public System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.Label lblStaffName;
        public System.Windows.Forms.RadioButton newRadioButton;
        public System.Windows.Forms.RadioButton existingRadioButton;
        public System.Windows.Forms.TextBox staffIDTextBox;
        public System.Windows.Forms.TextBox staffnameTextBox;
        public System.Windows.Forms.TextBox passwordTextBox;
    }
}