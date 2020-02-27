namespace Studio76.Forms
{
    partial class EditBookingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboEditBookingArtist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEmailDetails = new System.Windows.Forms.Label();
            this.lblPhoneNoDetails = new System.Windows.Forms.Label();
            this.lblPostcodeDetails = new System.Windows.Forms.Label();
            this.lblCountyDetails = new System.Windows.Forms.Label();
            this.lblTownDetails = new System.Windows.Forms.Label();
            this.lblStreetDetails = new System.Windows.Forms.Label();
            this.lblDOBDetails = new System.Windows.Forms.Label();
            this.lblSurnameDisplay = new System.Windows.Forms.Label();
            this.lblForenameDisplay = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBookingLength = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cbDepositPaid = new System.Windows.Forms.CheckBox();
            this.lblHourlyPrice = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cboBookingDate = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Artist";
            // 
            // cboEditBookingArtist
            // 
            this.cboEditBookingArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEditBookingArtist.FormattingEnabled = true;
            this.cboEditBookingArtist.Location = new System.Drawing.Point(108, 15);
            this.cboEditBookingArtist.Name = "cboEditBookingArtist";
            this.cboEditBookingArtist.Size = new System.Drawing.Size(149, 24);
            this.cboEditBookingArtist.TabIndex = 12;
            this.cboEditBookingArtist.SelectedIndexChanged += new System.EventHandler(this.CboEditBookingArtist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(108, 45);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(149, 24);
            this.txtCustomerName.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(12, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Email: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(12, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Phone No: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Address Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Address Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Customer Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Postcode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "County: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Town:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "DOB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Surname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(12, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Forename:";
            // 
            // lblEmailDetails
            // 
            this.lblEmailDetails.AutoSize = true;
            this.lblEmailDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmailDetails.Location = new System.Drawing.Point(148, 446);
            this.lblEmailDetails.Name = "lblEmailDetails";
            this.lblEmailDetails.Size = new System.Drawing.Size(0, 20);
            this.lblEmailDetails.TabIndex = 44;
            // 
            // lblPhoneNoDetails
            // 
            this.lblPhoneNoDetails.AutoSize = true;
            this.lblPhoneNoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhoneNoDetails.Location = new System.Drawing.Point(148, 416);
            this.lblPhoneNoDetails.Name = "lblPhoneNoDetails";
            this.lblPhoneNoDetails.Size = new System.Drawing.Size(0, 20);
            this.lblPhoneNoDetails.TabIndex = 43;
            // 
            // lblPostcodeDetails
            // 
            this.lblPostcodeDetails.AutoSize = true;
            this.lblPostcodeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPostcodeDetails.Location = new System.Drawing.Point(148, 344);
            this.lblPostcodeDetails.Name = "lblPostcodeDetails";
            this.lblPostcodeDetails.Size = new System.Drawing.Size(0, 20);
            this.lblPostcodeDetails.TabIndex = 42;
            // 
            // lblCountyDetails
            // 
            this.lblCountyDetails.AutoSize = true;
            this.lblCountyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCountyDetails.Location = new System.Drawing.Point(148, 313);
            this.lblCountyDetails.Name = "lblCountyDetails";
            this.lblCountyDetails.Size = new System.Drawing.Size(0, 20);
            this.lblCountyDetails.TabIndex = 41;
            // 
            // lblTownDetails
            // 
            this.lblTownDetails.AutoSize = true;
            this.lblTownDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTownDetails.Location = new System.Drawing.Point(148, 283);
            this.lblTownDetails.Name = "lblTownDetails";
            this.lblTownDetails.Size = new System.Drawing.Size(0, 20);
            this.lblTownDetails.TabIndex = 40;
            // 
            // lblStreetDetails
            // 
            this.lblStreetDetails.AutoSize = true;
            this.lblStreetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStreetDetails.Location = new System.Drawing.Point(148, 253);
            this.lblStreetDetails.Name = "lblStreetDetails";
            this.lblStreetDetails.Size = new System.Drawing.Size(0, 20);
            this.lblStreetDetails.TabIndex = 39;
            // 
            // lblDOBDetails
            // 
            this.lblDOBDetails.AutoSize = true;
            this.lblDOBDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDOBDetails.Location = new System.Drawing.Point(148, 182);
            this.lblDOBDetails.Name = "lblDOBDetails";
            this.lblDOBDetails.Size = new System.Drawing.Size(0, 20);
            this.lblDOBDetails.TabIndex = 38;
            // 
            // lblSurnameDisplay
            // 
            this.lblSurnameDisplay.AutoSize = true;
            this.lblSurnameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurnameDisplay.Location = new System.Drawing.Point(148, 153);
            this.lblSurnameDisplay.Name = "lblSurnameDisplay";
            this.lblSurnameDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblSurnameDisplay.TabIndex = 37;
            // 
            // lblForenameDisplay
            // 
            this.lblForenameDisplay.AutoSize = true;
            this.lblForenameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblForenameDisplay.Location = new System.Drawing.Point(148, 123);
            this.lblForenameDisplay.Name = "lblForenameDisplay";
            this.lblForenameDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblForenameDisplay.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(310, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 62;
            this.label20.Text = "Deposit Paid:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(310, 283);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 20);
            this.label21.TabIndex = 60;
            this.label21.Text = "Hourly Price:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(310, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 57;
            this.label19.Text = "Cost";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(310, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 54;
            this.label18.Text = "Total Cost:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(310, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "Booking Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(310, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 51;
            this.label15.Text = "Booking Length:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(310, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 20);
            this.label22.TabIndex = 50;
            this.label22.Text = "Booking Details";
            // 
            // txtBookingLength
            // 
            this.txtBookingLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingLength.Location = new System.Drawing.Point(474, 121);
            this.txtBookingLength.Name = "txtBookingLength";
            this.txtBookingLength.Size = new System.Drawing.Size(114, 24);
            this.txtBookingLength.TabIndex = 63;
            this.txtBookingLength.TextChanged += new System.EventHandler(this.TxtBookingLength_TextChanged);
            this.txtBookingLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBookingLength_KeyPress);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(474, 153);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(114, 20);
            this.dtDate.TabIndex = 64;
            // 
            // cbDepositPaid
            // 
            this.cbDepositPaid.AutoSize = true;
            this.cbDepositPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepositPaid.Location = new System.Drawing.Point(474, 186);
            this.cbDepositPaid.Name = "cbDepositPaid";
            this.cbDepositPaid.Size = new System.Drawing.Size(15, 14);
            this.cbDepositPaid.TabIndex = 65;
            this.cbDepositPaid.UseVisualStyleBackColor = true;
            // 
            // lblHourlyPrice
            // 
            this.lblHourlyPrice.AutoSize = true;
            this.lblHourlyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHourlyPrice.Location = new System.Drawing.Point(470, 283);
            this.lblHourlyPrice.Name = "lblHourlyPrice";
            this.lblHourlyPrice.Size = new System.Drawing.Size(0, 20);
            this.lblHourlyPrice.TabIndex = 67;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(470, 313);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCost.TabIndex = 66;
            this.lblTotalCost.Click += new System.EventHandler(this.LblTotalCost_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(310, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 68;
            this.label17.Text = "Start Time:";
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnConfirmEdit.FlatAppearance.BorderSize = 0;
            this.btnConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnConfirmEdit.Location = new System.Drawing.Point(314, 339);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(168, 30);
            this.btnConfirmEdit.TabIndex = 70;
            this.btnConfirmEdit.Text = "Save";
            this.btnConfirmEdit.UseVisualStyleBackColor = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.BtnConfirmEdit_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartTime.Location = new System.Drawing.Point(470, 223);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 20);
            this.lblStartTime.TabIndex = 71;
            this.lblStartTime.Click += new System.EventHandler(this.Label23_Click);
            // 
            // cboBookingDate
            // 
            this.cboBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookingDate.FormattingEnabled = true;
            this.cboBookingDate.Location = new System.Drawing.Point(267, 43);
            this.cboBookingDate.Name = "cboBookingDate";
            this.cboBookingDate.Size = new System.Drawing.Size(206, 26);
            this.cboBookingDate.TabIndex = 73;
            this.cboBookingDate.SelectedIndexChanged += new System.EventHandler(this.cboBookingDate_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.Location = new System.Drawing.Point(263, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 20);
            this.label23.TabIndex = 72;
            this.label23.Text = "Booking Date";
            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.cboBookingDate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblHourlyPrice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.cbDepositPaid);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtBookingLength);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblEmailDetails);
            this.Controls.Add(this.lblPhoneNoDetails);
            this.Controls.Add(this.lblPostcodeDetails);
            this.Controls.Add(this.lblCountyDetails);
            this.Controls.Add(this.lblTownDetails);
            this.Controls.Add(this.lblStreetDetails);
            this.Controls.Add(this.lblDOBDetails);
            this.Controls.Add(this.lblSurnameDisplay);
            this.Controls.Add(this.lblForenameDisplay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEditBookingArtist);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBookingForm_FormClosing);
            this.Load += new System.EventHandler(this.EditBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEditBookingArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEmailDetails;
        private System.Windows.Forms.Label lblPhoneNoDetails;
        private System.Windows.Forms.Label lblPostcodeDetails;
        private System.Windows.Forms.Label lblCountyDetails;
        private System.Windows.Forms.Label lblTownDetails;
        private System.Windows.Forms.Label lblStreetDetails;
        private System.Windows.Forms.Label lblDOBDetails;
        private System.Windows.Forms.Label lblSurnameDisplay;
        private System.Windows.Forms.Label lblForenameDisplay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBookingLength;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.CheckBox cbDepositPaid;
        private System.Windows.Forms.Label lblHourlyPrice;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cboBookingDate;
        private System.Windows.Forms.Label label23;
    }
}