namespace HallLibrary
{
    partial class UpdateMemberForm
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.nudFineDue = new System.Windows.Forms.NumericUpDown();
            this.lblFineDue = new System.Windows.Forms.Label();
            this.cboMembershipType = new System.Windows.Forms.ComboBox();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSuburb = new System.Windows.Forms.ComboBox();
            this.cboSuburbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(637, 446);
            this.txtPhoneNumber.MaxLength = 16;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 27);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(637, 404);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(229, 27);
            this.txtEmailAddress.TabIndex = 6;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(637, 309);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(414, 27);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(637, 265);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(234, 27);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(637, 216);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(229, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(637, 170);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(229, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.Color.LightGray;
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(637, 122);
            this.txtMemberID.MaxLength = 6;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 27);
            this.txtMemberID.TabIndex = 35;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(481, 449);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(116, 19);
            this.lblPhoneNumber.TabIndex = 32;
            this.lblPhoneNumber.Text = "*Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(486, 407);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(113, 19);
            this.lblEmailAddress.TabIndex = 31;
            this.lblEmailAddress.Text = "*Email Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(540, 363);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 30;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(480, 309);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(115, 19);
            this.lblStreetAddress.TabIndex = 29;
            this.lblStreetAddress.Text = "*Street Address:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(493, 265);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(104, 19);
            this.lblDateOfBirth.TabIndex = 28;
            this.lblDateOfBirth.Text = "*Date of Birth:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(504, 216);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "*First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(507, 170);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 19);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "*Last Name:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(510, 122);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(85, 19);
            this.lblMemberID.TabIndex = 25;
            this.lblMemberID.Text = "Member ID:";
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(411, 35);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(201, 33);
            this.lblAddMember.TabIndex = 47;
            this.lblAddMember.Text = "Update Member";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdateMember.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.Location = new System.Drawing.Point(256, 620);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(163, 58);
            this.btnUpdateMember.TabIndex = 10;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(602, 620);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(159, 58);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // nudFineDue
            // 
            this.nudFineDue.DecimalPlaces = 2;
            this.nudFineDue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFineDue.Location = new System.Drawing.Point(637, 502);
            this.nudFineDue.Name = "nudFineDue";
            this.nudFineDue.Size = new System.Drawing.Size(138, 27);
            this.nudFineDue.TabIndex = 8;
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Location = new System.Drawing.Point(517, 504);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(78, 19);
            this.lblFineDue.TabIndex = 51;
            this.lblFineDue.Text = "*Fine Due:";
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
            this.cboMembershipType.Location = new System.Drawing.Point(642, 550);
            this.cboMembershipType.MaxLength = 8;
            this.cboMembershipType.Name = "cboMembershipType";
            this.cboMembershipType.Size = new System.Drawing.Size(100, 27);
            this.cboMembershipType.TabIndex = 9;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(461, 553);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(136, 19);
            this.lblMembershipType.TabIndex = 53;
            this.lblMembershipType.Text = "*Membership Type:";
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(49, 122);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(355, 312);
            this.dgvMembers.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "*Indicates a required field";
            // 
            // cboSuburb
            // 
            this.cboSuburb.BackColor = System.Drawing.Color.LightGray;
            this.cboSuburb.Enabled = false;
            this.cboSuburb.FormattingEnabled = true;
            this.cboSuburb.Location = new System.Drawing.Point(637, 360);
            this.cboSuburb.Name = "cboSuburb";
            this.cboSuburb.Size = new System.Drawing.Size(203, 27);
            this.cboSuburb.TabIndex = 57;
            // 
            // cboSuburbID
            // 
            this.cboSuburbID.BackColor = System.Drawing.Color.LightGray;
            this.cboSuburbID.Enabled = false;
            this.cboSuburbID.FormattingEnabled = true;
            this.cboSuburbID.Location = new System.Drawing.Point(820, 360);
            this.cboSuburbID.Name = "cboSuburbID";
            this.cboSuburbID.Size = new System.Drawing.Size(20, 27);
            this.cboSuburbID.TabIndex = 58;
            // 
            // UpdateMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 704);
            this.Controls.Add(this.cboSuburbID);
            this.Controls.Add(this.cboSuburb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.cboMembershipType);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.nudFineDue);
            this.Controls.Add(this.lblFineDue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.lblAddMember);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMemberID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateMemberForm";
            this.Text = "Update Member";
            this.Load += new System.EventHandler(this.UpdateMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFineDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown nudFineDue;
        private System.Windows.Forms.Label lblFineDue;
        private System.Windows.Forms.ComboBox cboMembershipType;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSuburb;
        private System.Windows.Forms.ComboBox cboSuburbID;
    }
}