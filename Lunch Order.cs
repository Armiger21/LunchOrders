using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double hamburger = 6.95;
        double pizza = 5.95;
        double salad = 4.95;
        double hamburgerToppings = .75;
        double pizzaToppings = .50;
        double saladToppings = .25;
        double taxrate = .0775;
        public Form1()
        {
            InitializeComponent();      
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            PizzaBox.Visible = false;
            SaladBox.Visible = false;
            HamburgerBox.Visible = true;
            foreach (CheckBox c in PizzaBox.Controls)
            {
                c.Checked = false;
            }
            foreach (CheckBox c in SaladBox.Controls)
            {
                c.Checked = false;
            }
        }

        private void Pizza_CheckedChanged(object sender, EventArgs e)
        {
            HamburgerBox.Visible = false;
            SaladBox.Visible = false;
            PizzaBox.Visible = true;
            foreach (CheckBox c in HamburgerBox.Controls)
            {
                c.Checked = false;
            }
            foreach (CheckBox c in SaladBox.Controls)
            {
                c.Checked = false;
            }
        }

        private void SaladButton_CheckedChanged(object sender, EventArgs e)
        {
            HamburgerBox.Visible = false;
            PizzaBox.Visible = false;
            SaladBox.Visible = true;
            foreach (CheckBox c in PizzaBox.Controls)
            {
                c.Checked = false;
            }
            foreach (CheckBox c in HamburgerBox.Controls)
            {
                c.Checked = false;
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            double total = 0;
            double finaltotal = 0;
            double taxamt = 0;

            if (Hamburger.Checked)
            {
                total += hamburger;
                foreach (CheckBox c in HamburgerBox.Controls)
                {
                    if (c.Checked == true)
                        total += hamburgerToppings;
                }
            }
            else if (Pizza.Checked)
            {
                total += pizza;
                foreach (CheckBox c in PizzaBox.Controls)
                {
                    if (c.Checked == true)
                        total += pizzaToppings;
                }
            }
            else if (SaladButton.Checked)
            {
                total += salad;
                foreach (CheckBox c in SaladBox.Controls)
                {
                    if (c.Checked == true)
                        total += saladToppings;
                }
            }
            taxamt = total * taxrate;
            finaltotal = total + taxamt;

            subT.Text = total.ToString();
            tax.Text = taxamt.ToString();
            cost.Text = finaltotal.ToString();
        }

        private void clearText()
        {
            subT.Text = String.Empty;
            tax.Text = String.Empty;
            cost.Text = String.Empty;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void PizzaBox_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            clearText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
