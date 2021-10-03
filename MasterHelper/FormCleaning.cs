using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MasterHelper.Data;

namespace MasterHelper
{
    public partial class FormCleaning : MetroFramework.Forms.MetroForm
    {
        private Guna2ShadowPanel shadowPanelSelected;
        private Label labelSelected;
        public FormCleaning()
        {
            InitializeComponent();

            label80m2.Tag = 700000;
            label100m2.Tag = 800000;
            label150m2.Tag = 100000;
        }

        private void SelectShadowPanel(object sender, Label label)
        {
            if (shadowPanelSelected != null)
            {
                shadowPanelSelected.ShadowColor = Color.Black;
                shadowPanelSelected.ShadowDepth = 100;

                labelSelected.ForeColor = Color.Black;
            }

            Guna2ShadowPanel panel = (Guna2ShadowPanel)sender;
            panel.ShadowColor = Color.Tomato;
            panel.ShadowDepth = 255;

            label.ForeColor = Color.Tomato;

            shadowPanelSelected = panel;
            labelSelected = label;
        }
        private void FormCleaning_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Checked = true;
        }

        private void shadowPanel80_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label80m2);
        }

        private void shadowPanel100_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label100m2);
        }

        private void shadowPanel150_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label150m2);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int type = 1;
            string name = "Tổng vệ sinh";
            string address = this.textBoxAddress.Text;
            string date = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string time = this.dateTimePicker1.Value.ToString("HH:mm");

            Random r = new Random();
            int idEmployee = r.Next(0, 2);
            string employeeName = Employees.getInstant().getEmployeeById(idEmployee)[0].ToString();
            string employeeGender = Employees.getInstant().getEmployeeById(idEmployee)[1].ToString();

            int price = (int)labelSelected.Tag;

            Jobs.getInstant().add(type, address, date, time, employeeName, employeeGender, price, name);
            

            MessageBox.Show("Đăng việc thành công!!");
            this.Close();
        }

    }
}
