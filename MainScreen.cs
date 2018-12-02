using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public partial class MainScreen : Form
    {
        private Boolean sizeWindow = true;
        public MainScreen()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 70;
            }
            else
                panelMenuVertical.Width = 250;
        }

        private void pictureBoxShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSizeWindow_Click(object sender, EventArgs e)
        {
            if(sizeWindow)
            {
                this.WindowState = FormWindowState.Maximized;
                sizeWindow = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                sizeWindow = true;
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AddFormInPanel(object formContainer)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form frmContainer = formContainer as Form;
            frmContainer.TopLevel = false;
            frmContainer.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(frmContainer);
            this.panelContainer.Tag = frmContainer;
            frmContainer.Show();
        }
        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new DashBoard());
        }
    }
}
