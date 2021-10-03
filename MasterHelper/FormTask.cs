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
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            foreach (DataRow item in Jobs.getInstant().getJobs().Rows)
            {
                UserControlJob userControl = new UserControlJob(item);
                userControl.Tag = true;
                userControl.VisibleChanged += new System.EventHandler(this.UserControl_VisibleChanged);
                this.flowLayoutPanelContainer.Controls.Add(userControl);
            }
        }

        void UserControl_VisibleChanged(object sender, EventArgs e)
        {
            UserControl userControl = (UserControl)sender;
            if ((bool)userControl.Tag)
                return;

            userControl.Dispose();
            this.flowLayoutPanelContainer.Controls.Remove(userControl);
        }
    }
}
