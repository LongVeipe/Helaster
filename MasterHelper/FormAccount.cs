using MasterHelper.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterHelper
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            pictureBoxAvatar.Left = (pictureBoxAvatar.Parent.Width - pictureBoxAvatar.Width) / 2;
            //textBoxName.Left = (textBoxName.Parent.Width - textBoxName.Width) / 2;
            panelName.Left = (panelName.Parent.Width - panelName.Width) / 2;

            this.labelName.Text = Account.getInstant().getName();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (labelName.Visible)
            {
                labelName.Visible = false;
                textBoxName.Visible = true;
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Check;

                textBoxName.Text = Account.getInstant().getName();
            }
            else
            {
                labelName.Visible = true;
                textBoxName.Visible = false;
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Pen;

                Account.getInstant().setName(textBoxName.Text);
                labelName.Text = Account.getInstant().getName();

            }
        }
    }
}
