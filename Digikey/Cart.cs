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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Product_Details.qty;
                int cart_qty = Convert.ToInt32(textBox1.Text);
                double price;
                if (cart_qty <= 10)
                {
                    price = cart_qty * .11;
                    label9.Text = "\n0.11";
                    label11.Text = "\n" + price.ToString();
                    label12.Text = "Subtotal:     $" + price.ToString();
                }
                else if (cart_qty <= 20)
                { 
                    price = cart_qty * .10;
                    label9.Text = "\n0.10";
                    label11.Text = "\n" + price.ToString();
                    label12.Text = "Subtotal:     $" + price.ToString();
                }
                else if (cart_qty <= 100)
                {
                    price = cart_qty * .05;
                    label9.Text = "\n0.05";
                    label11.Text = "\n" + price.ToString();
                    label12.Text = "Subtotal:     $" + price.ToString();
                }
                else if (cart_qty <= 500)
                {
                    price = cart_qty * .03;
                    label9.Text = "\n0.03";
                    label11.Text = "\n" + price.ToString();
                    label12.Text = "Subtotal:     $" + price.ToString();
                }
                else if (cart_qty >= 1000)
                {
                    price = cart_qty * .02;
                    label9.Text = "\n0.02";
                    label11.Text = "\n" + price.ToString();
                    label12.Text = "Subtotal:     $" + price.ToString();
                }

            }
            catch (Exception ex) { }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Overlay.changeOverlay(Overlay.address);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label5.Text = "";
            textBox1.Visible = false;
            label7.Text = "";
            label9.Text = "";
            label11.Text = "";
            label12.Text = "Subtotal:     $0.00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    //Product_Details.qty;
                    int cart_qty = Convert.ToInt32(textBox1.Text);
                    double price;
                    if (cart_qty <= 10)
                    {
                        price = cart_qty * .11;
                        label9.Text = "\n0.11";
                        label11.Text = "\n" + price.ToString();
                        label12.Text = "Subtotal:     $" + price.ToString();
                    }
                    else if (cart_qty <= 20)
                    {
                        price = cart_qty * .10;
                        label9.Text = "\n0.10";
                        label11.Text = "\n" + price.ToString();
                        label12.Text = "Subtotal:     $" + price.ToString();
                    }
                    else if (cart_qty <= 100)
                    {
                        price = cart_qty * .05;
                        label9.Text = "\n0.05";
                        label11.Text = "\n" + price.ToString();
                        label12.Text = "Subtotal:     $" + price.ToString();
                    }
                    else if (cart_qty <= 500)
                    {
                        price = cart_qty * .03;
                        label9.Text = "\n0.03";
                        label11.Text = "\n" + price.ToString();
                        label12.Text = "Subtotal:     $" + price.ToString();
                    }
                    else if (cart_qty >= 1000)
                    {
                        price = cart_qty * .02;
                        label9.Text = "\n0.02";
                        label11.Text = "\n" + price.ToString();
                        label12.Text = "Subtotal:     $" + price.ToString();
                    }

                }
            }
            catch (Exception ex) { }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}