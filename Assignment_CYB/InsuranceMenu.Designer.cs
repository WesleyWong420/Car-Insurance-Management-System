namespace Assignment_CYB
{
    partial class InsuranceMenu
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
            this.customerIDTextLabel = new System.Windows.Forms.Label();
            this.customerNameTextLabel = new System.Windows.Forms.Label();
            this.insurancePackageTextLabel = new System.Windows.Forms.Label();
            this.insuranceDurationTextLabel = new System.Windows.Forms.Label();
            this.insuranceStartDateTextLabel = new System.Windows.Forms.Label();
            this.vehicleModelTextLabel = new System.Windows.Forms.Label();
            this.vehicleCostTextLabel = new System.Windows.Forms.Label();
            this.lastClaimDateTextLabel = new System.Windows.Forms.Label();
            this.NCDEntitlementTextLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.insuranceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblInsuranceDuration = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.lblVehicleCost = new System.Windows.Forms.Label();
            this.lblLastClaimDate = new System.Windows.Forms.Label();
            this.lblNCDEntitlement = new System.Windows.Forms.Label();
            this.insuranceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.staffScreenButton = new System.Windows.Forms.Button();
            this.customerScreenButton = new System.Windows.Forms.Button();
            this.insuranceScreenButton = new System.Windows.Forms.Button();
            this.homeScreenButton = new System.Windows.Forms.Button();
            this.customerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.insuranceDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerDetailsGroupBox.SuspendLayout();
            this.insuranceDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(44, 17);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(67, 17);
            this.lblStaffID.TabIndex = 11;
            this.lblStaffID.Text = "{staff_id}";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(98, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(449, 30);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "CAR INSURANCE MANAGEMENT SYSTEM";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(578, 17);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(90, 17);
            this.lblStaffName.TabIndex = 14;
            this.lblStaffName.Text = "{staff_name}";
            // 
            // customerIDTextLabel
            // 
            this.customerIDTextLabel.AutoSize = true;
            this.customerIDTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextLabel.Location = new System.Drawing.Point(6, 30);
            this.customerIDTextLabel.Name = "customerIDTextLabel";
            this.customerIDTextLabel.Size = new System.Drawing.Size(99, 17);
            this.customerIDTextLabel.TabIndex = 19;
            this.customerIDTextLabel.Text = "Customer ID:";
            // 
            // customerNameTextLabel
            // 
            this.customerNameTextLabel.AutoSize = true;
            this.customerNameTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextLabel.Location = new System.Drawing.Point(8, 66);
            this.customerNameTextLabel.Name = "customerNameTextLabel";
            this.customerNameTextLabel.Size = new System.Drawing.Size(120, 17);
            this.customerNameTextLabel.TabIndex = 20;
            this.customerNameTextLabel.Text = "Customer Name:";
            // 
            // insurancePackageTextLabel
            // 
            this.insurancePackageTextLabel.AutoSize = true;
            this.insurancePackageTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurancePackageTextLabel.Location = new System.Drawing.Point(6, 29);
            this.insurancePackageTextLabel.Name = "insurancePackageTextLabel";
            this.insurancePackageTextLabel.Size = new System.Drawing.Size(137, 17);
            this.insurancePackageTextLabel.TabIndex = 21;
            this.insurancePackageTextLabel.Text = "Insurance Package:";
            // 
            // insuranceDurationTextLabel
            // 
            this.insuranceDurationTextLabel.AutoSize = true;
            this.insuranceDurationTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceDurationTextLabel.Location = new System.Drawing.Point(6, 70);
            this.insuranceDurationTextLabel.Name = "insuranceDurationTextLabel";
            this.insuranceDurationTextLabel.Size = new System.Drawing.Size(139, 17);
            this.insuranceDurationTextLabel.TabIndex = 22;
            this.insuranceDurationTextLabel.Text = "Insurance Duration:";
            // 
            // insuranceStartDateTextLabel
            // 
            this.insuranceStartDateTextLabel.AutoSize = true;
            this.insuranceStartDateTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceStartDateTextLabel.Location = new System.Drawing.Point(6, 110);
            this.insuranceStartDateTextLabel.Name = "insuranceStartDateTextLabel";
            this.insuranceStartDateTextLabel.Size = new System.Drawing.Size(148, 17);
            this.insuranceStartDateTextLabel.TabIndex = 23;
            this.insuranceStartDateTextLabel.Text = "Insurance Start Date:";
            // 
            // vehicleModelTextLabel
            // 
            this.vehicleModelTextLabel.AutoSize = true;
            this.vehicleModelTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleModelTextLabel.Location = new System.Drawing.Point(6, 149);
            this.vehicleModelTextLabel.Name = "vehicleModelTextLabel";
            this.vehicleModelTextLabel.Size = new System.Drawing.Size(108, 17);
            this.vehicleModelTextLabel.TabIndex = 24;
            this.vehicleModelTextLabel.Text = "Vehicle Model:";
            // 
            // vehicleCostTextLabel
            // 
            this.vehicleCostTextLabel.AutoSize = true;
            this.vehicleCostTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCostTextLabel.Location = new System.Drawing.Point(6, 181);
            this.vehicleCostTextLabel.Name = "vehicleCostTextLabel";
            this.vehicleCostTextLabel.Size = new System.Drawing.Size(96, 17);
            this.vehicleCostTextLabel.TabIndex = 25;
            this.vehicleCostTextLabel.Text = "Vehicle Cost:";
            // 
            // lastClaimDateTextLabel
            // 
            this.lastClaimDateTextLabel.AutoSize = true;
            this.lastClaimDateTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastClaimDateTextLabel.Location = new System.Drawing.Point(6, 210);
            this.lastClaimDateTextLabel.Name = "lastClaimDateTextLabel";
            this.lastClaimDateTextLabel.Size = new System.Drawing.Size(119, 17);
            this.lastClaimDateTextLabel.TabIndex = 26;
            this.lastClaimDateTextLabel.Text = "Last Claim Date:";
            // 
            // NCDEntitlementTextLabel
            // 
            this.NCDEntitlementTextLabel.AutoSize = true;
            this.NCDEntitlementTextLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCDEntitlementTextLabel.Location = new System.Drawing.Point(6, 242);
            this.NCDEntitlementTextLabel.Name = "NCDEntitlementTextLabel";
            this.NCDEntitlementTextLabel.Size = new System.Drawing.Size(127, 17);
            this.NCDEntitlementTextLabel.TabIndex = 27;
            this.NCDEntitlementTextLabel.Text = "NCD Entitlement:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(171, 25);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.customerIDTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(283, 25);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.Enabled = false;
            this.multiButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiButton.Location = new System.Drawing.Point(282, 458);
            this.multiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(136, 49);
            this.multiButton.TabIndex = 0;
            this.multiButton.Text = "Purchase";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // insuranceTypeComboBox
            // 
            this.insuranceTypeComboBox.Enabled = false;
            this.insuranceTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceTypeComboBox.FormattingEnabled = true;
            this.insuranceTypeComboBox.Items.AddRange(new object[] {
            "Package A",
            "Package B",
            "Package C"});
            this.insuranceTypeComboBox.Location = new System.Drawing.Point(171, 26);
            this.insuranceTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceTypeComboBox.Name = "insuranceTypeComboBox";
            this.insuranceTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this.insuranceTypeComboBox.TabIndex = 0;
            this.insuranceTypeComboBox.Text = "Select One";
            this.insuranceTypeComboBox.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(168, 66);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(55, 17);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "{name}";
            this.lblCustomerName.Visible = false;
            // 
            // lblInsuranceDuration
            // 
            this.lblInsuranceDuration.AutoSize = true;
            this.lblInsuranceDuration.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceDuration.Location = new System.Drawing.Point(168, 70);
            this.lblInsuranceDuration.Name = "lblInsuranceDuration";
            this.lblInsuranceDuration.Size = new System.Drawing.Size(74, 17);
            this.lblInsuranceDuration.TabIndex = 34;
            this.lblInsuranceDuration.Text = "{duration}";
            this.lblInsuranceDuration.Visible = false;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleModel.Location = new System.Drawing.Point(168, 149);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(60, 17);
            this.lblVehicleModel.TabIndex = 35;
            this.lblVehicleModel.Text = "{model}";
            this.lblVehicleModel.Visible = false;
            // 
            // lblVehicleCost
            // 
            this.lblVehicleCost.AutoSize = true;
            this.lblVehicleCost.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleCost.Location = new System.Drawing.Point(168, 181);
            this.lblVehicleCost.Name = "lblVehicleCost";
            this.lblVehicleCost.Size = new System.Drawing.Size(47, 17);
            this.lblVehicleCost.TabIndex = 36;
            this.lblVehicleCost.Text = "{cost}";
            this.lblVehicleCost.Visible = false;
            // 
            // lblLastClaimDate
            // 
            this.lblLastClaimDate.AutoSize = true;
            this.lblLastClaimDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastClaimDate.Location = new System.Drawing.Point(168, 210);
            this.lblLastClaimDate.Name = "lblLastClaimDate";
            this.lblLastClaimDate.Size = new System.Drawing.Size(48, 17);
            this.lblLastClaimDate.TabIndex = 37;
            this.lblLastClaimDate.Text = "{date}";
            this.lblLastClaimDate.Visible = false;
            // 
            // lblNCDEntitlement
            // 
            this.lblNCDEntitlement.AutoSize = true;
            this.lblNCDEntitlement.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCDEntitlement.Location = new System.Drawing.Point(168, 242);
            this.lblNCDEntitlement.Name = "lblNCDEntitlement";
            this.lblNCDEntitlement.Size = new System.Drawing.Size(95, 17);
            this.lblNCDEntitlement.TabIndex = 38;
            this.lblNCDEntitlement.Text = "{entitlement}";
            this.lblNCDEntitlement.Visible = false;
            // 
            // insuranceDateTimePicker
            // 
            this.insuranceDateTimePicker.Enabled = false;
            this.insuranceDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceDateTimePicker.Location = new System.Drawing.Point(171, 102);
            this.insuranceDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceDateTimePicker.Name = "insuranceDateTimePicker";
            this.insuranceDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.insuranceDateTimePicker.TabIndex = 1;
            this.insuranceDateTimePicker.Visible = false;
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
            this.staffScreenButton.TabIndex = 4;
            this.staffScreenButton.Text = "Staff";
            this.staffScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.staffScreenButton.UseVisualStyleBackColor = true;
            this.staffScreenButton.Click += new System.EventHandler(this.staffScreenButton_Click);
            // 
            // customerScreenButton
            // 
            this.customerScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_103222;
            this.customerScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerScreenButton.Location = new System.Drawing.Point(332, 513);
            this.customerScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerScreenButton.Name = "customerScreenButton";
            this.customerScreenButton.Size = new System.Drawing.Size(160, 117);
            this.customerScreenButton.TabIndex = 3;
            this.customerScreenButton.Text = "Customer";
            this.customerScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerScreenButton.UseVisualStyleBackColor = true;
            this.customerScreenButton.Click += new System.EventHandler(this.customerScreenButton_Click);
            // 
            // insuranceScreenButton
            // 
            this.insuranceScreenButton.BackgroundImage = global::Assignment_CYB.Properties.Resources.Screenshot_2020_09_24_104101;
            this.insuranceScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insuranceScreenButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceScreenButton.Location = new System.Drawing.Point(167, 513);
            this.insuranceScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceScreenButton.Name = "insuranceScreenButton";
            this.insuranceScreenButton.Size = new System.Drawing.Size(160, 117);
            this.insuranceScreenButton.TabIndex = 2;
            this.insuranceScreenButton.Text = "Insurance";
            this.insuranceScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insuranceScreenButton.UseVisualStyleBackColor = true;
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
            this.homeScreenButton.TabIndex = 1;
            this.homeScreenButton.Text = "Home";
            this.homeScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeScreenButton.UseVisualStyleBackColor = true;
            this.homeScreenButton.Click += new System.EventHandler(this.homeScreenButton_Click);
            // 
            // customerDetailsGroupBox
            // 
            this.customerDetailsGroupBox.Controls.Add(this.customerIDTextLabel);
            this.customerDetailsGroupBox.Controls.Add(this.customerNameTextLabel);
            this.customerDetailsGroupBox.Controls.Add(this.customerIDTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.searchButton);
            this.customerDetailsGroupBox.Controls.Add(this.lblCustomerName);
            this.customerDetailsGroupBox.Location = new System.Drawing.Point(47, 58);
            this.customerDetailsGroupBox.Name = "customerDetailsGroupBox";
            this.customerDetailsGroupBox.Size = new System.Drawing.Size(391, 112);
            this.customerDetailsGroupBox.TabIndex = 40;
            this.customerDetailsGroupBox.TabStop = false;
            this.customerDetailsGroupBox.Text = "Customer Details";
            // 
            // insuranceDetailsGroupBox
            // 
            this.insuranceDetailsGroupBox.Controls.Add(this.insurancePackageTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.insuranceTypeComboBox);
            this.insuranceDetailsGroupBox.Controls.Add(this.lblNCDEntitlement);
            this.insuranceDetailsGroupBox.Controls.Add(this.insuranceDateTimePicker);
            this.insuranceDetailsGroupBox.Controls.Add(this.lblLastClaimDate);
            this.insuranceDetailsGroupBox.Controls.Add(this.insuranceDurationTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.lblVehicleCost);
            this.insuranceDetailsGroupBox.Controls.Add(this.insuranceStartDateTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.lblVehicleModel);
            this.insuranceDetailsGroupBox.Controls.Add(this.vehicleModelTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.vehicleCostTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.lastClaimDateTextLabel);
            this.insuranceDetailsGroupBox.Controls.Add(this.lblInsuranceDuration);
            this.insuranceDetailsGroupBox.Controls.Add(this.NCDEntitlementTextLabel);
            this.insuranceDetailsGroupBox.Location = new System.Drawing.Point(47, 176);
            this.insuranceDetailsGroupBox.Name = "insuranceDetailsGroupBox";
            this.insuranceDetailsGroupBox.Size = new System.Drawing.Size(391, 276);
            this.insuranceDetailsGroupBox.TabIndex = 41;
            this.insuranceDetailsGroupBox.TabStop = false;
            this.insuranceDetailsGroupBox.Text = "Insurance Details";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(126, 458);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 48);
            this.cancelButton.TabIndex = 42;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InsuranceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(656, 629);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.insuranceDetailsGroupBox);
            this.Controls.Add(this.customerDetailsGroupBox);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.staffScreenButton);
            this.Controls.Add(this.customerScreenButton);
            this.Controls.Add(this.insuranceScreenButton);
            this.Controls.Add(this.homeScreenButton);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lblStaffID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsuranceMenu";
            this.Text = "InsuranceMenu";
            this.Load += new System.EventHandler(this.InsuranceMenu_Load);
            this.customerDetailsGroupBox.ResumeLayout(false);
            this.customerDetailsGroupBox.PerformLayout();
            this.insuranceDetailsGroupBox.ResumeLayout(false);
            this.insuranceDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button homeScreenButton;
        private System.Windows.Forms.Button insuranceScreenButton;
        private System.Windows.Forms.Button customerScreenButton;
        private System.Windows.Forms.Button staffScreenButton;
        private System.Windows.Forms.Label customerIDTextLabel;
        private System.Windows.Forms.Label customerNameTextLabel;
        private System.Windows.Forms.Label insurancePackageTextLabel;
        private System.Windows.Forms.Label insuranceDurationTextLabel;
        private System.Windows.Forms.Label insuranceStartDateTextLabel;
        private System.Windows.Forms.Label vehicleModelTextLabel;
        private System.Windows.Forms.Label vehicleCostTextLabel;
        private System.Windows.Forms.Label lastClaimDateTextLabel;
        private System.Windows.Forms.Label NCDEntitlementTextLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblInsuranceDuration;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Label lblVehicleCost;
        private System.Windows.Forms.Label lblLastClaimDate;
        private System.Windows.Forms.Label lblNCDEntitlement;
        private System.Windows.Forms.DateTimePicker insuranceDateTimePicker;
        private System.Windows.Forms.GroupBox customerDetailsGroupBox;
        private System.Windows.Forms.GroupBox insuranceDetailsGroupBox;
        public System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.Label lblStaffName;
        public System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button multiButton;
        public System.Windows.Forms.ComboBox insuranceTypeComboBox;
        private System.Windows.Forms.Button cancelButton;
    }
}