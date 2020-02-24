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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.dgvEditBookings = new System.Windows.Forms.DataGridView();
            this.tpRemove = new System.Windows.Forms.TabPage();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.dgDeleteBookings = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAllBookings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crvReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblBookingsHeader = new System.Windows.Forms.Label();
            this.btnCustomerBooking = new System.Windows.Forms.Button();
            this.tcBookings.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatesPervious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddBookingSelectDate)).BeginInit();
            this.tpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBookings)).BeginInit();
            this.tpRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteBookings)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBookings
            // 
            this.tcBookings.Controls.Add(this.tpAdd);
            this.tcBookings.Controls.Add(this.tpEdit);
            this.tcBookings.Controls.Add(this.tpRemove);
            this.tcBookings.Controls.Add(this.tabPage1);
            this.tcBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBookings.Location = new System.Drawing.Point(12, 35);
            this.tcBookings.Name = "tcBookings";
            this.tcBookings.SelectedIndex = 0;
            this.tcBookings.Size = new System.Drawing.Size(1030, 614);
            this.tcBookings.TabIndex = 0;
            this.tcBookings.SelectedIndexChanged += new System.EventHandler(this.TcBookings_SelectedIndexChanged);
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            this.tpEdit.Controls.Add(this.btnEditBooking);
            this.tpEdit.Controls.Add(this.dgvEditBookings);
            this.tpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEdit.Location = new System.Drawing.Point(4, 29);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1022, 581);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnEditBooking.FlatAppearance.BorderSize = 0;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnEditBooking.Location = new System.Drawing.Point(848, 545);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(168, 30);
            this.btnEditBooking.TabIndex = 17;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.BtnEditBooking_Click);
            // 
            // dgvEditBookings
            // 
            this.dgvEditBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditBookings.EnableHeadersVisualStyles = false;
            this.dgvEditBookings.Location = new System.Drawing.Point(6, 6);
            this.dgvEditBookings.MultiSelect = false;
            this.dgvEditBookings.Name = "dgvEditBookings";
            this.dgvEditBookings.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditBookings.RowTemplate.Height = 40;
            this.dgvEditBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditBookings.Size = new System.Drawing.Size(1010, 536);
            this.dgvEditBookings.TabIndex = 16;
            // 
            // tpRemove
            // 
            this.tpRemove.Controls.Add(this.btnDeleteBooking);
            this.tpRemove.Controls.Add(this.dgDeleteBookings);
            this.tpRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRemove.Location = new System.Drawing.Point(4, 29);
            this.tpRemove.Name = "tpRemove";
            this.tpRemove.Size = new System.Drawing.Size(1022, 581);
            this.tpRemove.TabIndex = 2;
            this.tpRemove.Text = "Remove";
            this.tpRemove.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.btnDeleteBooking.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnDeleteBooking.Location = new System.Drawing.Point(845, 545);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(168, 30);
            this.btnDeleteBooking.TabIndex = 18;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.BtnDeleteBooking_Click);
            // 
            // dgDeleteBookings
            // 
            this.dgDeleteBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDeleteBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDeleteBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDeleteBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeleteBookings.EnableHeadersVisualStyles = false;
            this.dgDeleteBookings.Location = new System.Drawing.Point(6, 6);
            this.dgDeleteBookings.MultiSelect = false;
            this.dgDeleteBookings.Name = "dgDeleteBookings";
            this.dgDeleteBookings.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDeleteBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDeleteBookings.RowTemplate.Height = 40;
            this.dgDeleteBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDeleteBookings.Size = new System.Drawing.Size(1010, 536);
            this.dgDeleteBookings.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCustomerBooking);
            this.tabPage1.Controls.Add(this.btnAllBookings);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 581);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAllBookings
            // 
            this.btnAllBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnAllBookings.FlatAppearance.BorderSize = 0;
            this.btnAllBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnAllBookings.Location = new System.Drawing.Point(3, 42);
            this.btnAllBookings.Name = "btnAllBookings";
            this.btnAllBookings.Size = new System.Drawing.Size(163, 30);
            this.btnAllBookings.TabIndex = 22;
            this.btnAllBookings.Text = "All Bookings";
            this.btnAllBookings.UseVisualStyleBackColor = false;
            this.btnAllBookings.Click += new System.EventHandler(this.btnAllBookings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crvReports);
            this.panel1.Location = new System.Drawing.Point(172, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 575);
            this.panel1.TabIndex = 21;
            // 
            // crvReports
            // 
            this.crvReports.ActiveViewIndex = -1;
            this.crvReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReports.Location = new System.Drawing.Point(0, 0);
            this.crvReports.Name = "crvReports";
            this.crvReports.Size = new System.Drawing.Size(847, 575);
            this.crvReports.TabIndex = 0;
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
            // btnCustomerBooking
            // 
            this.btnCustomerBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnCustomerBooking.FlatAppearance.BorderSize = 0;
            this.btnCustomerBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnCustomerBooking.Location = new System.Drawing.Point(3, 6);
            this.btnCustomerBooking.Name = "btnCustomerBooking";
            this.btnCustomerBooking.Size = new System.Drawing.Size(163, 30);
            this.btnCustomerBooking.TabIndex = 23;
            this.btnCustomerBooking.Text = "Customer Booking";
            this.btnCustomerBooking.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBookings)).EndInit();
            this.tpRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteBookings)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvEditBookings;
        private System.Windows.Forms.Button btnConfirmDates;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.DataGridView dgDeleteBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAllBookings;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReports;
        private System.Windows.Forms.Button btnCustomerBooking;
    }
}