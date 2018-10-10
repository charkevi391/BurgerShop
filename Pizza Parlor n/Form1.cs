using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlor_n
{
    public partial class BigBurgerBar : Form
    {
        public BigBurgerBar()
        {
            InitializeComponent();
        }

            private void titleLabel_Click(object sender, EventArgs e)
            {

            }

            private void calculateButton_Click(object sender, EventArgs e)
            {
                try
                {
                    toppingNumber = Convert.ToDouble(textBox1.Text);
                    double totalCost = BASE_PIZZA_COST + TOPPING_COST * toppingNumber;

                    outputLabel.Text = "Your pizza costs " + totalCost.ToString("C");

                }
                catch
                {
                    outputLabel.Text = "has to be a #";
                }
