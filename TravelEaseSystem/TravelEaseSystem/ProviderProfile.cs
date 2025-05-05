using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEaseSystem
{
    public partial class ProviderProfile: Form
    {
        public ProviderProfile()
        {
            InitializeComponent();
            this.Load += header_load;
        }

        ContextMenuStrip profileMenu = new ContextMenuStrip();
        ContextMenuStrip notifMenu = new ContextMenuStrip();
        private void header_load(object sender, EventArgs e)
        {
            // Add menu items to profile menu
            profileMenu.Items.Add("View Profile", null, (s, ev) => MessageBox.Show("View Profile clicked"));
            profileMenu.Items.Add("Logout", null, (s, ev) => Application.Exit());

            // Hook the click event for PictureBox
            pfpPictureBox.Click += profilePictureBox_Click;

            notifPictureBox.Click += notifPictureBox_Click;

            // Temporary hardcoded sample notifs
            notifMenu.Items.Add("Booking #123 confirmed", null, (s, ev) => MessageBox.Show("Opening Booking #123..."));
            notifMenu.Items.Add("Reminder: Payment due", null, (s, ev) => MessageBox.Show("Opening Payment Reminder..."));
            notifMenu.Items.Add("New message from admin", null, (s, ev) => MessageBox.Show("Opening Message..."));
        }

        private void notifPictureBox_Click(object sender, EventArgs e)
        {
            int menuWidth = notifMenu.GetPreferredSize(Size.Empty).Width;

            int iconRight = notifPictureBox.Right;
            int x = iconRight - menuWidth;

            // Ensure it doesn't go off the left edge
            if (x < 0) x = 0;

            notifMenu.Show(notifPictureBox, new Point(x - notifPictureBox.Left, notifPictureBox.Height));
        }
        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            int menuWidth = profileMenu.GetPreferredSize(Size.Empty).Width;

            int iconRight = pfpPictureBox.Right;
            int x = iconRight - menuWidth;

            // Ensure it doesn't go off the left edge
            if (x < 0) x = 0;

            profileMenu.Show(pfpPictureBox, new Point(x - pfpPictureBox.Left, pfpPictureBox.Height));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
