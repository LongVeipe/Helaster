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
            textBoxName.Left = (textBoxName.Parent.Width - textBoxName.Width) / 2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
