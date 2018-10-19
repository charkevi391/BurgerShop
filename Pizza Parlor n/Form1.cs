using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// Created by: Charlie Kevill
/// Completed: 10/15/2018
/// Description: A basic cashregister for A burger resturant.

namespace Pizza_Parlor_n
{
    public partial class BigBurgerBar : Form 

    {
        const double HST_TAX = 0.13;
        const double FRI_CST = 1.89;
        const double BGR_CST = 2.49;
        const double DRI_CST = 0.99;
        double burgersPurchased;
        double friesPurchased;
        double drinksPurchased;
        double totalCost;
        double taxTotal;
        double subTotal;
        double ammountTendered;
        double changeGiven;


        public BigBurgerBar()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgersPurchased = Convert.ToDouble(burgerBox.Text);
                friesPurchased = Convert.ToDouble(friesBox.Text);
                drinksPurchased = Convert.ToDouble(drinkBox.Text);

                subTotal = burgersPurchased * BGR_CST + friesPurchased * FRI_CST + drinksPurchased * DRI_CST;
                label8.Text = "$" + subTotal;

                taxTotal = subTotal * HST_TAX;
                label9.Text = "$" + taxTotal;

                totalCost = subTotal * HST_TAX + subTotal;
                label10.Text = "$" + totalCost;
            }
            catch
            {
                label15.Visible = true;

            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgersPurchased = Convert.ToDouble(burgerBox.Text);
                friesPurchased = Convert.ToDouble(friesBox.Text);
                drinksPurchased = Convert.ToDouble(drinkBox.Text);
                subTotal = burgersPurchased * BGR_CST + friesPurchased * FRI_CST + drinksPurchased * DRI_CST;
                taxTotal = subTotal * HST_TAX;
                totalCost = subTotal * HST_TAX + subTotal;
                ammountTendered = Convert.ToDouble(tenderedBox.Text);
                changeGiven = ammountTendered - totalCost;
                label14.Text = changeGiven.ToString("C");
            }

            catch
            {
                label15.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font titleFont = new Font("Times New Roman", 25, FontStyle.Bold);
            Font boldFont = new Font("Consolas", 15, FontStyle.Bold);
            Font normalFont = new Font("Consolas", 15);
            Font bigFont = new Font("Consolas", 30);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Test);

            burgersPurchased = Convert.ToDouble(burgerBox.Text);
            friesPurchased = Convert.ToDouble(friesBox.Text);
            drinksPurchased = Convert.ToDouble(drinkBox.Text);
            subTotal = burgersPurchased * BGR_CST + friesPurchased * FRI_CST + drinksPurchased * DRI_CST;
            taxTotal = subTotal * HST_TAX;
            totalCost = subTotal * HST_TAX + subTotal;
            ammountTendered = Convert.ToDouble(tenderedBox.Text);
            changeGiven = ammountTendered - totalCost;

            g.DrawRectangle(blackPen, 600, 20, 400, 500);

            g.DrawString("Big Burger Bar", normalFont, blackBrush, 620, 40);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Oct, 12th, 2018", normalFont, blackBrush, 620, 60);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Order #1017", normalFont, blackBrush, 620, 80);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Big Burger Bar", normalFont, blackBrush, 620, 100);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Hamburgers        x" + burgerBox.Text + " @ 2.49" , normalFont, blackBrush, 620, 120);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Fries             x" + friesBox.Text + " @ 1.89", normalFont, blackBrush, 620, 140);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Drinks            x" + drinkBox.Text + " @ 0.99", normalFont, blackBrush, 620, 160);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("SubTotal          $" + subTotal, normalFont, blackBrush, 620, 180);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Tax               $" + taxTotal, normalFont, blackBrush, 620, 200);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Total             $" + totalCost, normalFont, blackBrush, 620, 220);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Tendered          $" + ammountTendered, normalFont, blackBrush, 620, 240);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Change            $" + changeGiven, normalFont, blackBrush, 620, 260);
            player.Play();
            Thread.Sleep(1000);
            g.DrawString("Thanks for eating here! :) ", normalFont, blackBrush, 620, 280);
            player.Play();

        }
    }
}