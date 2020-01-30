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
            frmBookings booking = new frmBookings();
            booking.TopLevel = false;
            pnlMain.Controls.Add(booking);
            booking.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;
            booking.Show();
        }
    }
}
