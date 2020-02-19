namespace Studio76.Forms
{
    partial class frmBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcBookings = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.btnConfirmDates = new System.Windows.Forms.Button();
            this.pbDatesNext = new System.Windows.Forms.PictureBox();
            this.pbDatesPervious = new System.Windows.Forms.PictureBox();
            this.lblCurrentDates = new System.Windows.Forms.Label();
            this.dgAddBookingSelectDate = new System.Windows.Forms.DataGridView();
            this.cbMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBookingFindDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAddBookingArtist = new System.Windows.Forms.ComboBox();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tpRemove = new System.Windows.Forms.TabPage();
            this.lblBookingsHeader = new System.Windows.Forms.Label();
            this.tcBookings.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesPervious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddBookingSelectDate)).BeginInit();
            this.tpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBookings
            // 
            this.tcBookings.Controls.Add(this.tpAdd);
            this.tcBookings.Controls.Add(this.tpEdit);
            this.tcBookings.Controls.Add(this.tpRemove);
            this.tcBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBookings.Location = new System.Drawing.Point(12, 35);
            this.tcBookings.Name = "tcBookings";
            this.tcBookings.SelectedIndex = 0;
            this.tcBookings.Size = new System.Drawing.Size(1030, 614);
            this.tcBookings.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.btnConfirmDates);
            this.tpAdd.Controls.Add(this.pbDatesNext);
            this.tpAdd.Controls.Add(this.pbDatesPervious);
            this.tpAdd.Controls.Add(this.lblCurrentDates);
            this.tpAdd.Controls.Add(this.dgAddBookingSelectDate);
            this.tpAdd.Controls.Add(this.btnAddBookingFindDate);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Controls.Add(this.cboAddBookingArtist);
            this.tpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAdd.Location = new System.Drawing.Point(4, 29);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1022, 581);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            this.tpAdd.UseVisualStyleBackColor = true;
            this.tpAdd.Click += new System.EventHandler(this.TpAdd_Click);
            // 
            // btnConfirmDates
            // 
            this.btnConfirmDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnConfirmDates.FlatAppearance.BorderSize = 0;
            this.btnConfirmDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnConfirmDates.Location = new System.Drawing.Point(10, 545);
            this.btnConfirmDates.Name = "btnConfirmDates";
            this.btnConfirmDates.Size = new System.Drawing.Size(168, 30);
            this.btnConfirmDates.TabIndex = 16;
            this.btnConfirmDates.Text = "Confirm Dates";
            this.btnConfirmDates.UseVisualStyleBackColor = false;
            this.btnConfirmDates.Click += new System.EventHandler(this.btnConfirmDates_Click);
            // 
            // pbDatesNext
            // 
            this.pbDatesNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDatesNext.BackgroundImage")));
            this.pbDatesNext.Image = ((System.Drawing.Image)(resources.GetObject("pbDatesNext.Image")));
            this.pbDatesNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbDatesNext.InitialImage")));
            this.pbDatesNext.Location = new System.Drawing.Point(991, 39);
            this.pbDatesNext.Name = "pbDatesNext";
            this.pbDatesNext.Size = new System.Drawing.Size(25, 25);
            this.pbDatesNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDatesNext.TabIndex = 15;
            this.pbDatesNext.TabStop = false;
            this.pbDatesNext.Click += new System.EventHandler(this.PbDatesNext_Click);
            // 
            // pbDatesPervious
            // 
            this.pbDatesPervious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDatesPervious.BackgroundImage")));
            this.pbDatesPervious.Enabled = false;
            this.pbDatesPervious.Image = ((System.Drawing.Image)(resources.GetObject("pbDatesPervious.Image")));
            this.pbDatesPervious.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbDatesPervious.InitialImage")));
            this.pbDatesPervious.Location = new System.Drawing.Point(184, 36);
            this.pbDatesPervious.Name = "pbDatesPervious";
            this.pbDatesPervious.Size = new System.Drawing.Size(25, 25);
            this.pbDatesPervious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDatesPervious.TabIndex = 14;
            this.pbDatesPervious.TabStop = false;
            this.pbDatesPervious.Click += new System.EventHandler(this.PbDatesPervious_Click);
            // 
            // lblCurrentDates
            // 
            this.lblCurrentDates.AutoSize = true;
            this.lblCurrentDates.Location = new System.Drawing.Point(488, 45);
            this.lblCurrentDates.Name = "lblCurrentDates";
            this.lblCurrentDates.Size = new System.Drawing.Size(186, 20);
            this.lblCurrentDates.TabIndex = 13;
            this.lblCurrentDates.Text = "23 /01/2020 - 30/01/2020";
            this.lblCurrentDates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgAddBookingSelectDate
            // 
            this.dgAddBookingSelectDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAddBookingSelectDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAddBookingSelectDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAddBookingSelectDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddBookingSelectDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbMonday,
            this.cbTuesday,
            this.cbWednesday,
            this.cbThursday,
            this.cbFriday,
            this.cbSaturday,
            this.cbSunday});
            this.dgAddBookingSelectDate.EnableHeadersVisualStyles = false;
            this.dgAddBookingSelectDate.Location = new System.Drawing.Point(184, 67);
            this.dgAddBookingSelectDate.MultiSelect = false;
            this.dgAddBookingSelectDate.Name = "dgAddBookingSelectDate";
            this.dgAddBookingSelectDate.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAddBookingSelectDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAddBookingSelectDate.RowTemplate.Height = 40;
            this.dgAddBookingSelectDate.Size = new System.Drawing.Size(832, 509);
            this.dgAddBookingSelectDate.TabIndex = 12;
            this.dgAddBookingSelectDate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAddBookingSelectDate_CellMouseClick);
            // 
            // cbMonday
            // 
            this.cbMonday.HeaderText = "Monday";
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.ReadOnly = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.HeaderText = "Tuesday";
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.ReadOnly = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.HeaderText = "Wednesday";
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.ReadOnly = true;
            // 
            // cbThursday
            // 
            this.cbThursday.HeaderText = "Thursday";
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.ReadOnly = true;
            // 
            // cbFriday
            // 
            this.cbFriday.HeaderText = "Friday";
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.ReadOnly = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.HeaderText = "Saturday";
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.ReadOnly = true;
            // 
            // cbSunday
            // 
            this.cbSunday.HeaderText = "Sunday";
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.ReadOnly = true;
            // 
            // btnAddBookingFindDate
            // 
            this.btnAddBookingFindDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnAddBookingFindDate.FlatAppearance.BorderSize = 0;
            this.btnAddBookingFindDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBookingFindDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnAddBookingFindDate.Location = new System.Drawing.Point(10, 92);
            this.btnAddBookingFindDate.Name = "btnAddBookingFindDate";
            this.btnAddBookingFindDate.Size = new System.Drawing.Size(168, 30);
            this.btnAddBookingFindDate.TabIndex = 11;
            this.btnAddBookingFindDate.Text = "Get Date";
            this.btnAddBookingFindDate.UseVisualStyleBackColor = false;
            this.btnAddBookingFindDate.Click += new System.EventHandler(this.BtnAddBookingFindDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artist";
            // 
            // cboAddBookingArtist
            // 
            this.cboAddBookingArtist.FormattingEnabled = true;
            this.cboAddBookingArtist.Location = new System.Drawing.Point(10, 59);
            this.cboAddBookingArtist.Name = "cboAddBookingArtist";
            this.cboAddBookingArtist.Size = new System.Drawing.Size(168, 28);
            this.cboAddBookingArtist.TabIndex = 9;
            this.cboAddBookingArtist.SelectedIndexChanged += new System.EventHandler(this.CboAddBookingArtist_SelectedIndexChanged);
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.dataGridView1);
            this.tpEdit.Controls.Add(this.panel1);
            this.tpEdit.Controls.Add(this.label3);
            this.tpEdit.Controls.Add(this.comboBox2);
            this.tpEdit.Controls.Add(this.label1);
            this.tpEdit.Controls.Add(this.comboBox1);
            this.tpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEdit.Location = new System.Drawing.Point(4, 29);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1022, 581);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(248, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(768, 509);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Thursday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Saturday";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Sunday";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(10, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 414);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artist";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // tpRemove
            // 
            this.tpRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRemove.Location = new System.Drawing.Point(4, 29);
            this.tpRemove.Name = "tpRemove";
            this.tpRemove.Size = new System.Drawing.Size(1022, 581);
            this.tpRemove.TabIndex = 2;
            this.tpRemove.Text = "Remove";
            this.tpRemove.UseVisualStyleBackColor = true;
            // 
            // lblBookingsHeader
            // 
            this.lblBookingsHeader.AutoSize = true;
            this.lblBookingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingsHeader.Location = new System.Drawing.Point(13, 9);
            this.lblBookingsHeader.Name = "lblBookingsHeader";
            this.lblBookingsHeader.Size = new System.Drawing.Size(96, 24);
            this.lblBookingsHeader.TabIndex = 1;
            this.lblBookingsHeader.Text = "Bookings";
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 661);
            this.Controls.Add(this.lblBookingsHeader);
            this.Controls.Add(this.tcBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookings";
            this.Text = "frmBookings";
            this.Load += new System.EventHandler(this.frmBookings_Load);
            this.tcBookings.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesPervious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddBookingSelectDate)).EndInit();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcBookings;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.TabPage tpRemove;
        private System.Windows.Forms.Label lblBookingsHeader;
        private System.Windows.Forms.Button btnAddBookingFindDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAddBookingArtist;
        private System.Windows.Forms.DataGridView dgAddBookingSelectDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbSunday;
        private System.Windows.Forms.Label lblCurrentDates;
        private System.Windows.Forms.PictureBox pbDatesPervious;
        private System.Windows.Forms.PictureBox pbDatesNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnConfirmDates;
    }
}