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
    public partial class FormAirCon : MetroFramework.Forms.MetroForm
    {
        List<Guna2NumericUpDown> numericUpDownsSelected;
        public FormAirCon()
        {
            InitializeComponent();
        }

        private void selectTypeAirCon(Object sender, Guna2Panel panel, Label label)
        {
            Guna2NumericUpDown numericUpDown = (Guna2NumericUpDown)sender;
            if(numericUpDown.Value == 0)
            {
                panel.BorderColor = Color.Black;
                label.ForeColor = Color.Black;
                numericUpDown.BorderColor = Color.LightGray;
                numericUpDown.UpDownButtonFillColor = Color.Transparent;
                numericUpDown.UpDownButtonForeColor = Color.DimGray;
                numericUpDownsSelected.Remove(numericUpDown);
            }    
            else
            {
                panel.BorderColor = Color.LightSeaGreen;
                label.ForeColor = Color.LightSeaGreen;
                numericUpDown.BorderColor = Color.LightSeaGreen;
                numericUpDown.UpDownButtonFillColor = Color.LightSeaGreen;
                numericUpDown.UpDownButtonForeColor = Color.White;
                if(numericUpDownsSelected.Count == 0)
                    numericUpDownsSelected.Add(numericUpDown);
                else if (numericUpDownsSelected.Any(item => item != numericUpDown))
                    numericUpDownsSelected.Add(numericUpDown);
            }    
        }
        private void FormAirCon_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;

            numericUpDown2HP1.Tag = 150000;
            numericUpdown2HP2.Tag = 170000;
            numericUpDownCadinet.Tag = 250000;
            numericUpdown3HP1.Tag = 300000;
            numericUpDown3HP2.Tag = 450000;

            numericUpDownsSelected = new List<Guna2NumericUpDown>();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Checked = true;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectTypeAirCon(sender, panel2HP1, label2HP1);
        }

        private void numericUpdown2HP2_ValueChanged(object sender, EventArgs e)
        {
            selectTypeAirCon(sender, panel2HP2, label2HP2);
        }

        private void numericUpDownCadinet_ValueChanged(object sender, EventArgs e)
        {
            selectTypeAirCon(sender, panelCadinet, labelCadinet);
        }

        private void numericUpdown3HP1_ValueChanged(object sender, EventArgs e)
        {
            selectTypeAirCon(sender, panel3HP1, label3HP1);
        }

        private void numericUpDown3HP2_ValueChanged(object sender, EventArgs e)
        {
            selectTypeAirCon(sender, panel3HP2, label3HP2);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int type = 3;
            string name = "Vệ sinh máy lạnh";
            string address = this.textBoxAddress.Text;
            string date = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string time = this.dateTimePicker1.Value.ToString("HH:mm");

            Random r = new Random();
            int idEmployee = r.Next(0, 2);
            string employeeName = Employees.getInstant().getEmployeeById(idEmployee)[0].ToString();
            string employeeGender = Employees.getInstant().getEmployeeById(idEmployee)[1].ToString();

            int price = 0;
            foreach(Guna2NumericUpDown item in numericUpDownsSelected)
            {
                price += (int)item.Value * (int)item.Tag;
            }    


            Jobs.getInstant().add(type, address, date, time, employeeName, employeeGender, price, name);


            MessageBox.Show("Đăng việc thành công!!");
            this.Close();
        }
    }
}
