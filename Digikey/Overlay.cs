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
    public partial class Overlay : Form
    {
        public static TopMenu topMenu;
        public static Filter filter;


        public Overlay()
        {
            InitializeComponent();
            topMenu = new TopMenu();
            topMenu.TopLevel = false;
            topMenu.Parent = pForms;
            topMenu.Show();

            filter = new Filter();
            filter.TopLevel = false;
            filter.Parent = pForms;
            //filter.Show();

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

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

        private void TbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbSearch.Text == "Search") tbSearch.Text = "";
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.BackColor = Color.White;
        }

        private void LblDigikey_Click(object sender, EventArgs e)
        {
            filter.Hide();
            topMenu.Show();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {
                if (tbSearch.Text.ToLower().Contains("transistor") || tbSearch.Text.ToLower().Contains("bipolar"))
                {
                    Overlay.topMenu.Hide();
                    Overlay.filter.Show();
                    Overlay.filter.showTransistor();
                }
                else if (tbSearch.Text.ToLower().Contains("molex") || tbSearch.Text.ToLower().Contains("connector"))
                {
                    Overlay.topMenu.Hide();
                    Overlay.filter.Show();
                    Overlay.filter.showConnector();
                }
                else
                {
                    Overlay.topMenu.Hide();
                    Overlay.filter.Show();
                    Overlay.filter.showTransistor();
                }



                
            }
        }
    }
}
