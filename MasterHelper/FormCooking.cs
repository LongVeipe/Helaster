using Guna.UI2.WinForms;
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
    public partial class FormCooking : MetroFramework.Forms.MetroForm
    {

        private Guna2ShadowPanel shadowPanelSelected;
        private Label labelSelected;

        public FormCooking()
        {
            InitializeComponent();
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
            panel.ShadowColor = Color.BlueViolet;
            panel.ShadowDepth = 255;

            label.ForeColor = Color.BlueViolet;

            shadowPanelSelected = panel;
            labelSelected = label;
        }
        private void FormCooking_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;

            this.shadowPanel20.Tag = 120000;
            this.shadowPanel25.Tag = 150000;
            this.shadowPanel30.Tag = 180000;
            this.shadowPanel35.Tag = 210000;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Checked = true;
        }

        private void shadowPanel20_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label20);
        }

        private void shadowPanel25_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label25);
        }

        private void shadowPanel30_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label30);
        }

        private void shadowPanel35_MouseClick(object sender, MouseEventArgs e)
        {
            SelectShadowPanel(sender, label35);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int type = 5;
            string name = "Tổng vệ sinh";
            string address = this.textBoxAddress.Text;
            string date = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string time = this.dateTimePicker1.Value.ToString("HH:mm");

            Random r = new Random();
            int idEmployee = r.Next(0, 2);
            string employeeName = Employees.getInstant().getEmployeeById(idEmployee)[0].ToString();
            string employeeGender = Employees.getInstant().getEmployeeById(idEmployee)[1].ToString();

            int price = (int)shadowPanelSelected.Tag;

            Jobs.getInstant().add(type, address, date, time, employeeName, employeeGender, price, name);


            MessageBox.Show("Đăng việc thành công!!");
            this.Close();
        }
    }
}
