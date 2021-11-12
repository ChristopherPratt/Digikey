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
    public partial class Support : Form
    {
        Button btn = new Button();
        public Support()
        {
            InitializeComponent();
            /*
                        btn1 = new Button();
                        btn.Tag = "Yo";

                        btn1 = new Button();
                        btn1 = new Button();
                        btn1 = new Button();
                        btn.SetBounds(400, 400, 400, 400);
                        btn.Location = new Point(96,213);
                        Controls.Add(btn);
                        btn.BackColor = Color.Black;
                        string name = "ddsad";
                        btn.Click += new EventHandler(this.btnEvent_click);*/


            /*            for (int x = 0; x < btn.GetLength(0); x++)
                        {
                            for (int y = 0; y < btn.GetLength(1); y++)
                            {
                                btn[x, y] = new Button();
                                btn[x, y].SetBounds(40 * x, 40 * y, 40, 40);
                                btn[x, y].Click += new EventHandler(this.btnEvent_click);
                                Controls.Add(btn[x, y]);
                                btn[x, y].BackColor = Color.Black;
                            }
                        }*/
        }


        void btnEvent_click(object sender, EventArgs e)
        {
            if ("Yo" == (String)((Button)sender).Tag)
            {

            }
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Red":
                    ctrl.BackColor = Color.Yellow;
                    break;
                case "Black":
                    ctrl.BackColor = Color.White;
                    break;
                case "White":
                    ctrl.BackColor = Color.Red;
                    break;
                case "Yellow":
                    ctrl.BackColor = Color.Purple;
                    break;
                default:
                    ctrl.BackColor = Color.Red;
                    break;
            }
        }

        void click(int opt)
        {
            if (opt == 4) //Delivery
            {
                button4.BackColor = SystemColors.ControlDark;
                button2.BackColor = SystemColors.ControlLight;
                button2.Text = "Payment and Account";
                button3.BackColor = SystemColors.ControlLight;
                button3.Text = "Ordering";
                button1.BackColor = SystemColors.ControlLight;
                button1.Text = "Returns and Order Issues";

                button4.Text = "Delivery   >";

                linkLabel1.Text = "What is the delivery time and cost?";
                linkLabel2.Text = "How can I check my delivery status?";
                linkLabel3.Text = "What happens if I don't provide a valid VAT ID with my order?";
            }
            else if (opt == 3) //Ordering
            {
                button3.BackColor = SystemColors.ControlDark;
                button1.BackColor = SystemColors.ControlLight;
                button1.Text = "Returns and Order Issues";
                button2.BackColor = SystemColors.ControlLight;
                button2.Text = "Payment and Account";
                button4.BackColor = SystemColors.ControlLight;
                button4.Text = "Delivery";

                button3.Text = "Ordering   >";

                linkLabel1.Text = "How do I schedule an order online?";
                linkLabel2.Text = "How do I request a quote online?";
                linkLabel3.Text = "When will I receive an order acknowledgement?";
            }
            else if (opt == 2) //Payment & Account
            {
                button2.BackColor = SystemColors.ControlDark;
                button1.BackColor = SystemColors.ControlLight;
                button1.Text = "Returns and Order Issues";
                button3.BackColor = SystemColors.ControlLight;
                button3.Text = "Ordering";
                button4.BackColor = SystemColors.ControlLight;
                button4.Text = "Delivery";

                button2.Text = "Payment and Account   >";

                linkLabel1.Text = "When will I or my business be charged?";
                linkLabel2.Text = "What Payment Methods are available?";
                linkLabel3.Text = "How do I find out Tax ID & VAT information?";
            }
            else if (opt == 1) //Returns
            {
                button1.BackColor = SystemColors.ControlDark;
                button2.BackColor = SystemColors.ControlLight;
                button2.Text = "Payment and Account";
                button3.BackColor = SystemColors.ControlLight;
                button3.Text = "Ordering";
                button4.BackColor = SystemColors.ControlLight;
                button4.Text = "Delivery";

                button1.Text = "Returns and Order Issues >";

                linkLabel1.Text = "What is Digi-Key’s return policy?";
                linkLabel2.Text = "What should I do if my order has an issue?";
                linkLabel3.Text = "What should I do if the part I ordered from Digi-Key are no longer needed?";
            }
       
        }

        private void Support_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            click(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click(2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            click(1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
