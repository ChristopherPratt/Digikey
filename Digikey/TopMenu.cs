using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digikey
{
    public partial class TopMenu : Form
    {
        public TopMenu()
        {
            InitializeComponent();
        }

        public void showFilterPage(string type)
        {
            Filter f = new Filter();
            f.TopLevel = false;
           
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Filter f = new Filter();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();
        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbResult_TextChanged(object sender, EventArgs e)
        {

        }

      


        private void TbSemiconductors_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbSemiconductors.Text == "Search") tbSemiconductors.Text = "";
            tbSemiconductors.TextAlign = HorizontalAlignment.Left;
            tbSemiconductors.BackColor = Color.White;
        }


        private void TbPassives_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPassives.Text == "Search") tbPassives.Text = "";
            tbPassives.TextAlign = HorizontalAlignment.Left;
            tbPassives.BackColor = Color.White;
        }

        private void TbElectromech_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbElectromech.Text == "Search") tbElectromech.Text = "";
            tbElectromech.TextAlign = HorizontalAlignment.Left;
            tbElectromech.BackColor = Color.White;
        }

        private void TbPower_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPower.Text == "Search") tbPower.Text = "";
            tbPower.TextAlign = HorizontalAlignment.Left;
            tbPower.BackColor = Color.White;
        }

        private void TbAutomation_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbAutomation.Text == "Search") tbAutomation.Text = "";
            tbAutomation.TextAlign = HorizontalAlignment.Left;
            tbAutomation.BackColor = Color.White;
        }

        private void TbConnect_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbConnect.Text == "Search") tbConnect.Text = "";
            tbConnect.TextAlign = HorizontalAlignment.Left;
            tbConnect.BackColor = Color.White;
        }

        private void TbCables_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbCables.Text == "Search") tbCables.Text = "";
            tbCables.TextAlign = HorizontalAlignment.Left;
            tbCables.BackColor = Color.White;
        }

        private void TbTestProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbTestProducts.Text == "Search") tbTestProducts.Text = "";
            tbTestProducts.TextAlign = HorizontalAlignment.Left;
            tbTestProducts.BackColor = Color.White;
        }

        private void TbTools_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbTools.Text == "Search") tbTools.Text = "";
            tbTools.TextAlign = HorizontalAlignment.Left;
            tbTools.BackColor = Color.White;
        }

        private void TbHardware_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbHardware.Text == "Search") tbHardware.Text = "";
            tbHardware.TextAlign = HorizontalAlignment.Left;
            tbHardware.BackColor = Color.White;
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Overlay.topMenu.Hide();
            Overlay.filter.Show();
            Overlay.filter.showTransistor();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Overlay.topMenu.Hide();
            Overlay.filter.Show();
            Overlay.filter.showTransistor();
        }

        private void TbSemiconductors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Overlay.topMenu.Hide();
                Overlay.filter.Show();
                Overlay.filter.showTransistor();
            }
        }

        private void Label58_Click(object sender, EventArgs e)
        {
            Overlay.topMenu.Hide();
            Overlay.filter.Show();
            Overlay.filter.showConnector();
        }

        private void TbConnect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Overlay.topMenu.Hide();
                Overlay.filter.Show();
                Overlay.filter.showConnector();
            }
        }
    }
}
