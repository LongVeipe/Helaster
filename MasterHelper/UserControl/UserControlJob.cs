using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterHelper.Data;

namespace MasterHelper
{
    public partial class UserControlJob : UserControl
    {
        private DataRow job;
        Color colorTheme;
        public UserControlJob(DataRow job)
        {
            InitializeComponent();
            this.job = job;
        }

        private void setColorTheme()
        {

            int type = (int)job[1];

            switch (type)
            {
                case 1:
                    colorTheme = Color.Tomato;
                    break;
                case 2:
                    colorTheme = Color.LimeGreen;
                    break;
                case 3:
                    colorTheme = Color.Turquoise;
                    break;
                case 5:
                    colorTheme = Color.BlueViolet;
                    break;
                default:
                    colorTheme = Color.Black;
                    break;
            }
        }

        void setColorToControls()
        {
            this.iconDate.IconColor = colorTheme;
            this.iconTime.IconColor = colorTheme;
            this.iconPrice.IconColor = colorTheme;
            this.iconAddress.IconColor = colorTheme;

            this.buttonPay.BorderColor = colorTheme;
            this.buttonPay.ForeColor = colorTheme;
        }

        void setData()
        {
            string address = job[2].ToString();
            string date = job[3].ToString();
            string time = job[4].ToString();
            string employeeName = job[5].ToString();
            string employeeGender = job[6].ToString();
            int price = (int)job[7];
            string name = job[8].ToString();

            this.labelDate.Text = date;
            this.labelTime.Text = time;
            this.labelPrice.Text = price.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " đ";
            this.labelAddress.Text = address;
            this.labelTitle.Text = name;
        }
        private void UserControlJob_Load(object sender, EventArgs e)
        {
            setColorTheme();
            setColorToControls();
            setData();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            string id = job[0].ToString();
            Jobs.getInstant().Pay(id);
            MessageBox.Show("Thanh toán thành công " + labelPrice.Text + " !!!");
            this.Tag = false;
            this.Visible = false;
        }

    }
}
