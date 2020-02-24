namespace Studio76.Forms
{
    partial class frmArtists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomerHeader = new System.Windows.Forms.Label();
            this.tcBookings = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cboArtistType = new System.Windows.Forms.ComboBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtistSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtistForename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.dgvEditArtist = new System.Windows.Forms.DataGridView();
            this.tpRemove = new System.Windows.Forms.TabPage();
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            this.dgvDeleteArtist = new System.Windows.Forms.DataGridView();
            this.tcBookings.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditArtist)).BeginInit();
            this.tpRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerHeader
            // 
            this.lblCustomerHeader.AutoSize = true;
            this.lblCustomerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeader.Location = new System.Drawing.Point(13, 10);
            this.lblCustomerHeader.Name = "lblCustomerHeader";
            this.lblCustomerHeader.Size = new System.Drawing.Size(66, 24);
            this.lblCustomerHeader.TabIndex = 5;
            this.lblCustomerHeader.Text = "Artists";
            // 
            // tcBookings
            // 
            this.tcBookings.Controls.Add(this.tpAdd);
            this.tcBookings.Controls.Add(this.tpEdit);
            this.tcBookings.Controls.Add(this.tpRemove);
            this.tcBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBookings.Location = new System.Drawing.Point(12, 36);
            this.tcBookings.Name = "tcBookings";
            this.tcBookings.SelectedIndex = 0;
            this.tcBookings.Size = new System.Drawing.Size(1030, 614);
            this.tcBookings.TabIndex = 4;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.cboArtistType);
            this.tpAdd.Controls.Add(this.btnAddArtist);
            this.tpAdd.Controls.Add(this.label5);
            this.tpAdd.Controls.Add(this.label9);
            this.tpAdd.Controls.Add(this.txtHourlyRate);
            this.tpAdd.Controls.Add(this.label4);
            this.tpAdd.Controls.Add(this.dtDOB);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.txtArtistSurname);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Controls.Add(this.txtArtistForename);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAdd.Location = new System.Drawing.Point(4, 29);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1022, 581);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 364);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Artist Type";
            // 
            // cboArtistType
            // 
            this.cboArtistType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArtistType.FormattingEnabled = true;
            this.cboArtistType.Location = new System.Drawing.Point(20, 387);
            this.cboArtistType.Name = "cboArtistType";
            this.cboArtistType.Size = new System.Drawing.Size(149, 28);
            this.cboArtistType.TabIndex = 34;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnAddArtist.FlatAppearance.BorderSize = 0;
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnAddArtist.Location = new System.Drawing.Point(20, 421);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(207, 30);
            this.btnAddArtist.TabIndex = 33;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = false;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Payment  Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Artist Details";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(20, 324);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(140, 26);
            this.txtHourlyRate.TabIndex = 17;
            this.txtHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourlyRate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 301);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hourly Rate";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(20, 198);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(207, 26);
            this.dtDOB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artist DOB";
            // 
            // txtArtistSurname
            // 
            this.txtArtistSurname.Location = new System.Drawing.Point(20, 135);
            this.txtArtistSurname.Name = "txtArtistSurname";
            this.txtArtistSurname.Size = new System.Drawing.Size(207, 26);
            this.txtArtistSurname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artist Surname";
            // 
            // txtArtistForename
            // 
            this.txtArtistForename.Location = new System.Drawing.Point(20, 72);
            this.txtArtistForename.Name = "txtArtistForename";
            this.txtArtistForename.Size = new System.Drawing.Size(207, 26);
            this.txtArtistForename.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artist Forename";
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.btnEditArtist);
            this.tpEdit.Controls.Add(this.dgvEditArtist);
            this.tpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEdit.Location = new System.Drawing.Point(4, 29);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1022, 581);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnEditArtist.FlatAppearance.BorderSize = 0;
            this.btnEditArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnEditArtist.Location = new System.Drawing.Point(848, 545);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(168, 30);
            this.btnEditArtist.TabIndex = 19;
            this.btnEditArtist.Text = "Edit Artist";
            this.btnEditArtist.UseVisualStyleBackColor = false;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // dgvEditArtist
            // 
            this.dgvEditArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditArtist.EnableHeadersVisualStyles = false;
            this.dgvEditArtist.Location = new System.Drawing.Point(6, 6);
            this.dgvEditArtist.MultiSelect = false;
            this.dgvEditArtist.Name = "dgvEditArtist";
            this.dgvEditArtist.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditArtist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditArtist.RowTemplate.Height = 40;
            this.dgvEditArtist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditArtist.Size = new System.Drawing.Size(1010, 536);
            this.dgvEditArtist.TabIndex = 18;
            // 
            // tpRemove
            // 
            this.tpRemove.Controls.Add(this.btnDeleteArtist);
            this.tpRemove.Controls.Add(this.dgvDeleteArtist);
            this.tpRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRemove.Location = new System.Drawing.Point(4, 29);
            this.tpRemove.Name = "tpRemove";
            this.tpRemove.Size = new System.Drawing.Size(1022, 581);
            this.tpRemove.TabIndex = 2;
            this.tpRemove.Text = "Remove";
            this.tpRemove.UseVisualStyleBackColor = true;
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.btnDeleteArtist.FlatAppearance.BorderSize = 0;
            this.btnDeleteArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnDeleteArtist.Location = new System.Drawing.Point(848, 548);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(168, 30);
            this.btnDeleteArtist.TabIndex = 21;
            this.btnDeleteArtist.Text = "Delete Artist";
            this.btnDeleteArtist.UseVisualStyleBackColor = false;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // dgvDeleteArtist
            // 
            this.dgvDeleteArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeleteArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeleteArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeleteArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteArtist.EnableHeadersVisualStyles = false;
            this.dgvDeleteArtist.Location = new System.Drawing.Point(6, 6);
            this.dgvDeleteArtist.MultiSelect = false;
            this.dgvDeleteArtist.Name = "dgvDeleteArtist";
            this.dgvDeleteArtist.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeleteArtist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeleteArtist.RowTemplate.Height = 40;
            this.dgvDeleteArtist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeleteArtist.Size = new System.Drawing.Size(1010, 536);
            this.dgvDeleteArtist.TabIndex = 20;
            // 
            // frmArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 661);
            this.Controls.Add(this.lblCustomerHeader);
            this.Controls.Add(this.tcBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtists";
            this.Text = "frmArtists";
            this.tcBookings.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditArtist)).EndInit();
            this.tpRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerHeader;
        private System.Windows.Forms.TabControl tcBookings;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtistSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtistForename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.DataGridView dgvEditArtist;
        private System.Windows.Forms.TabPage tpRemove;
        private System.Windows.Forms.Button btnDeleteArtist;
        private System.Windows.Forms.DataGridView dgvDeleteArtist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboArtistType;
    }
}