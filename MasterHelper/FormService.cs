using Guna.UI2.AnimatorNS;
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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private async void load1()
        {
            await Task.Delay(200);

            guna2Transition1.Show(this.shadowPanelCleaning, false, Animation.Mosaic);
            guna2Transition1.ShowSync(this.shadowPanelMarket, false, Animation.HorizSlide);
            guna2Transition1.ShowSync(this.shadowPanelAirCon, false, Animation.HorizSlide);
            guna2Transition1.ShowSync(this.shadowPanelSofa, false, Animation.HorizSlide);
        }

        private async void load2()
        {

            await Task.Delay(200);
            guna2Transition2.Show(this.shadowPanelCooking, false, Animation.HorizSlide);
            guna2Transition2.ShowSync(this.shadowPanelWash, false, Animation.HorizSlide);
            guna2Transition2.ShowSync(this.shadowPanelTakeCare, false, Animation.HorizSlide);
            guna2Transition2.ShowSync(this.shadowPanelDisinfection, false, Animation.HorizSlide);
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            load1();
            load2();
        }

        private void buttonCleaning_Click(object sender, EventArgs e)
        {
            FormCleaning formCleaning = new FormCleaning();
            formCleaning.ShowDialog();
            formCleaning.Dispose();

        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            FormMarket formMarket = new FormMarket();
            formMarket.ShowDialog();
            formMarket.Dispose();
        }

        private void buttonAirCon_Click(object sender, EventArgs e)
        {
            FormAirCon formAirCon = new FormAirCon();
            formAirCon.ShowDialog();
            formAirCon.Dispose();
        }

        private void buttonSofa_Click(object sender, EventArgs e)
        {

        }

        private void buttonCooking_Click(object sender, EventArgs e)
        {
            FormCooking formCooking = new FormCooking();
            formCooking.ShowDialog();
            formCooking.Dispose();
        }

        private void buttonWash_Click(object sender, EventArgs e)
        {

        }

        private void buttonTakeCare_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisinfection_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
