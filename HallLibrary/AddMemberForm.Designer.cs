namespace HallLibrary
{
    partial class AddMemberForm
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
            this.lblAddMember = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.lblFineDue = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cboMembershipType = new System.Windows.Forms.ComboBox();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            this.nudFineDue = new System.Windows.Forms.NumericUpDown();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboSuburbID = new System.Windows.Forms.ComboBox();
            this.cboPostCode = new System.Windows.Forms.ComboBox();
            this.lblSelectSuburb = new System.Windows.Forms.Label();
            this.lblMemberDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineDue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(343, 21);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(163, 33);
            this.lblAddMember.TabIndex = 0;
            this.lblAddMember.Text = "Add Member";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(127, 249);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(93, 19);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "*Member ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(130, 297);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 19);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "*Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(491, 297);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "*First Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(116, 345);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(104, 19);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "*Date of Birth:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(105, 396);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(115, 19);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "*Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(145, 138);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(65, 19);
            this.lblSuburb.TabIndex = 6;
            this.lblSuburb.Text = "*Suburb:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(107, 425);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(113, 19);
            this.lblEmailAddress.TabIndex = 7;
            this.lblEmailAddress.Text = "*Email Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(102, 467);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(116, 19);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "*Phone Number:";
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(84, 508);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(136, 19);
            this.lblMembershipType.TabIndex = 9;
            this.lblMembershipType.Text = "*Membership Type:";
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Location = new System.Drawing.Point(398, 513);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(78, 19);
            this.lblFineDue.TabIndex = 10;
            this.lblFineDue.Text = "*Fine Due:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.Color.LightGray;
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(239, 249);
            this.txtMemberID.MaxLength = 6;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 27);
            this.txtMemberID.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(239, 297);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(229, 27);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(603, 297);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(229, 27);
            this.txtFirstName.TabIndex = 5;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(239, 343);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(154, 27);
            this.dtpDateOfBirth.TabIndex = 6;
            this.dtpDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(239, 393);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(414, 27);
            this.txtStreetAddress.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(239, 467);
            this.txtPhoneNumber.MaxLength = 16;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 27);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // cboMembershipType
            // 
            this.cboMembershipType.AutoCompleteCustomSource.AddRange(new string[] {
            "Adult",
            "Chile"});
            this.cboMembershipType.FormattingEnabled = true;
            this.cboMembershipType.Items.AddRange(new object[] {
            "Adult",
            "Child"});
            this.cboMembershipType.Location = new System.Drawing.Point(239, 505);
            this.cboMembershipType.MaxLength = 8;
            this.cboMembershipType.Name = "cboMembershipType";
            this.cboMembershipType.Size = new System.Drawing.Size(100, 27);
            this.cboMembershipType.TabIndex = 10;
            // 
            // cboSuburb
            // 
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(309, 135);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(182, 27);
            this.cboSuburb.TabIndex = 2;
            // 
            // nudFineDue
            // 
            this.nudFineDue.DecimalPlaces = 2;
            this.nudFineDue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFineDue.Location = new System.Drawing.Point(495, 511);
            this.nudFineDue.Name = "nudFineDue";
            this.nudFineDue.Size = new System.Drawing.Size(120, 27);
            this.nudFineDue.TabIndex = 11;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddMember.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(197, 591);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(159, 46);
            this.btnAddMember.TabIndex = 12;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(478, 581);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 56);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboSuburbID
            // 
            this.cboSuburbID.FormattingEnabled = true;
            this.cboSuburbID.Location = new System.Drawing.Point(229, 135);
            this.cboSuburbID.Name = "cboSuburbID";
            this.cboSuburbID.Size = new System.Drawing.Size(74, 27);
            this.cboSuburbID.TabIndex = 1;
            // 
            // cboPostCode
            // 
            this.cboPostCode.FormattingEnabled = true;
            this.cboPostCode.Location = new System.Drawing.Point(497, 135);
            this.cboPostCode.Name = "cboPostCode";
            this.cboPostCode.Size = new System.Drawing.Size(97, 27);
            this.cboPostCode.TabIndex = 3;
            // 
            // lblSelectSuburb
            // 
            this.lblSelectSuburb.AutoSize = true;
            this.lblSelectSuburb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSuburb.Location = new System.Drawing.Point(80, 97);
            this.lblSelectSuburb.Name = "lblSelectSuburb";
            this.lblSelectSuburb.Size = new System.Drawing.Size(124, 23);
            this.lblSelectSuburb.TabIndex = 25;
            this.lblSelectSuburb.Text = "Select Suburb:";
            // 
            // lblMemberDetails
            // 
            this.lblMemberDetails.AutoSize = true;
            this.lblMemberDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberDetails.Location = new System.Drawing.Point(80, 197);
            this.lblMemberDetails.Name = "lblMemberDetails";
            this.lblMemberDetails.Size = new System.Drawing.Size(144, 23);
            this.lblMemberDetails.TabIndex = 26;
            this.lblMemberDetails.Text = "Member Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "* Indicates a required field";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(239, 434);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(252, 27);
            this.txtEmailAddress.TabIndex = 28;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 671);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMemberDetails);
            this.Controls.Add(this.lblSelectSuburb);
            this.Controls.Add(this.cboPostCode);
            this.Controls.Add(this.cboSuburbID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.nudFineDue);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.cboMembershipType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblFineDue);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblAddMember);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMemberForm";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFineDue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.Label lblFineDue;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cboMembershipType;
        private System.Windows.Forms.ComboBox cboSuburb;
        private System.Windows.Forms.NumericUpDown nudFineDue;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboSuburbID;
        private System.Windows.Forms.ComboBox cboPostCode;
        private System.Windows.Forms.Label lblSelectSuburb;
        private System.Windows.Forms.Label lblMemberDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailAddress;
    }
}