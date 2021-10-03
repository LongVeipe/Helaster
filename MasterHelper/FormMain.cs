using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterHelper
{
    public partial class FormMain : Form
    {
        private Guna2Button currentBtn;
        private Form currentChildForm;

        public FormMain()
        {
            InitializeComponent();
            currentBtn = this.buttonService;
            OpenChildForm(new FormService());
        }

        private void ActivateButton(object sender)
        {
            if (sender == null)
                return;

            DisableButton();
            currentBtn = (Guna2Button)sender;
            this.pictureBoxSlide.Location = new Point(pictureBoxSlide.Location.X, currentBtn.Location.Y - 27);
            currentBtn.ImageAlign = HorizontalAlignment.Right;
            currentBtn.Padding = new Padding(13, 0, 0, 0);
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.Padding = new Padding(20, 0, 0, 0);
                currentBtn.ImageAlign = HorizontalAlignment.Left;
            }    
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                this.currentChildForm.Close();
                this.currentChildForm.Dispose();
            }

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DradForm);
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void DradForm(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonActivity_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTask());
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormService());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormAccount());
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            DradForm(sender, e);
        }

    }
}
