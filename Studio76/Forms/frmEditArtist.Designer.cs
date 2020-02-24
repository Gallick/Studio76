namespace Studio76.Forms
{
    partial class frmEditArtist
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
            this.label6 = new System.Windows.Forms.Label();
            this.cboArtistType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 354);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Artist Type";
            // 
            // cboArtistType
            // 
            this.cboArtistType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArtistType.FormattingEnabled = true;
            this.cboArtistType.Location = new System.Drawing.Point(16, 377);
            this.cboArtistType.Name = "cboArtistType";
            this.cboArtistType.Size = new System.Drawing.Size(149, 28);
            this.cboArtistType.TabIndex = 47;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnSave.Location = new System.Drawing.Point(16, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 30);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Payment  Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Artist Details";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(16, 314);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(140, 26);
            this.txtHourlyRate.TabIndex = 43;
            this.txtHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourlyRate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Hourly Rate";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(16, 188);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(207, 26);
            this.dtDOB.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Artist DOB";
            // 
            // txtArtistSurname
            // 
            this.txtArtistSurname.Location = new System.Drawing.Point(16, 125);
            this.txtArtistSurname.Name = "txtArtistSurname";
            this.txtArtistSurname.Size = new System.Drawing.Size(207, 26);
            this.txtArtistSurname.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Artist Surname";
            // 
            // txtArtistForename
            // 
            this.txtArtistForename.Location = new System.Drawing.Point(16, 62);
            this.txtArtistForename.Name = "txtArtistForename";
            this.txtArtistForename.Size = new System.Drawing.Size(207, 26);
            this.txtArtistForename.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Artist Forename";
            // 
            // frmEditArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboArtistType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtistSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtistForename);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditArtist";
            this.Text = "frmEditArtist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditArtist_FormClosing);
            this.Load += new System.EventHandler(this.frmEditArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboArtistType;
        private System.Windows.Forms.Button btnSave;
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
    }
}