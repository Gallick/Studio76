using Studio76.Classes;
using Studio76.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio76
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            ChangeToBookingForm();
        }
        
        public void ClearCurrentForm()
        {
            pnlMain.Controls.Clear();
        }

        public void ChangeToBookingForm()
        {
            frmBookings booking = new frmBookings();
            booking.TopLevel = false;
            pnlMain.Controls.Add(booking);
            booking.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;

            booking.masterForm = this;

            booking.Show();
        }

        public void ChangeFormToBookingConfirmation(SelectionBooking _booking)
        {
            frmBookingConfirmation booking = new frmBookingConfirmation();
            booking.TopLevel = false;
            pnlMain.Controls.Add(booking);
            booking.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;
            booking.currentBooking = _booking;
            booking.Show();
            booking.SetupInformation();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearCurrentForm();
            ChangeToBookingForm();
        }
    }
}
