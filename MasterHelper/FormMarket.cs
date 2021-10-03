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
    public partial class FormMarket : MetroFramework.Forms.MetroForm
    {
        private Guna2Button currentMoneyButton;
        public FormMarket()
        {
            InitializeComponent();
        }

        private void SelectMoney(object sender)
        {
            if (this.currentMoneyButton != null)
                currentMoneyButton.Checked = false;

            Guna2Button button = (Guna2Button)sender;
            this.currentMoneyButton = button;
            button.Checked = true;
        }
        private void button300_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void button500_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void button700_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void button800_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void button900_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            SelectMoney(sender);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textboxAddress.Text != "")
                textboxAddress.BorderColor = Color.LimeGreen;
        }

        private void FormMarket_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;

            button1000.Tag = 1000000;
            button300.Tag = 300000;
            button500.Tag = 500000;
            button700.Tag = 700000;
            button800.Tag = 800000;
            button900.Tag = 900000;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Checked = true;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            int type = 2;
            string name = "Đi chợ hộ";
            string address = this.textboxAddress.Text;
            string date = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string time = this.dateTimePicker1.Value.ToString("HH:mm");

            Random r = new Random();
            int idEmployee = r.Next(0, 2);
            string employeeName = Employees.getInstant().getEmployeeById(idEmployee)[0].ToString();
            string employeeGender = Employees.getInstant().getEmployeeById(idEmployee)[1].ToString();

            int price = 250000;

            Jobs.getInstant().add(type, address, date, time, employeeName, employeeGender, price, name);


            MessageBox.Show("Đăng việc thành công!!");
            this.Close();
        }
    }
}
