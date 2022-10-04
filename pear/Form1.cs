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

namespace pear
{
    public partial class Form1 : Form
    {
        //create the variables needed
        double galaPrice = 2;
        double honeycrispPrice= 4;
        double grannySmithPrice = 5;
        double galaAmount = 0;
        double honeycrispAmount = 0;
        double grannySmithAmount = 0;
        double totalAmount = 0;
        double taxAmount = 0;
        double taxRate = .13;
        double subtotal = 0;
        double change = 0;
        double totalChange = 0;
        //the print sound 
        SoundPlayer receipt = new SoundPlayer(Properties.Resources.Receipt);
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //calculates the subtotal, tax and total
            try
            {
                galaAmount = Convert.ToDouble(galaInput.Text);
                honeycrispAmount = Convert.ToDouble(honeycrispInput.Text);
                grannySmithAmount = Convert.ToDouble(grannySmithInput.Text);
                if (galaAmount + honeycrispAmount + grannySmithAmount < 500)
                    { 
                subtotal = galaAmount * galaPrice + honeycrispAmount * honeycrispPrice + grannySmithAmount * grannySmithPrice;
                taxAmount = subtotal * taxRate;
                totalAmount = taxAmount + subtotal;

                subTotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalAmount.ToString("C")}";
                changeButton.Enabled = true;
                    }
                else
                {
                    //if they order to many apples
                subTotalOutput.Text = $"";
                taxOutput.Text = $"";
                totalOutput.Text = $"";
                subTotalOutput.Text = $"Insufficient";
                taxOutput.Text = $"stock";
                }
            }
            catch
            {
                //if a lttter is in the input
                subTotalOutput.Text = $"";
                taxOutput.Text = $"";
                totalOutput.Text = $"";
                subTotalOutput.Text = $"Input Error";
                taxOutput.Text = $"Input Error";
                totalOutput.Text = $"Input Error";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //calculates change  and checks if they have imputeded enough 
                change = Convert.ToDouble(changeInput.Text);
                if (change >= totalAmount)
                {
                    totalChange = change - totalAmount;
                    changeOutput.Text = $"{totalChange.ToString("C")}";
                    printButton.Enabled = true;
                }
                else
                {
                    changeOutput.Text = $"Insufficient funds"; 
                }
            }
            catch 
            {
                // if a letter is inputed
                subTotalOutput.Text = $"";
                taxOutput.Text = $"";
                totalOutput.Text = $"";
                subTotalOutput.Text = $"Input Error";
                taxOutput.Text = $"Input Error";
                totalOutput.Text = $"Input Error";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //prints the reciept
            recipteTitle.Text = $"              Pear";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\n\n\n\n    order number 4092 ";
            receiptOutput.Text += $"\n\n   September 29, 2022 ";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);
            if (galaAmount > 0)
            {
                receiptOutput.Text += $"\n\nGala          x{galaAmount} @ {galaPrice} ";
                receipt.Play();

                Refresh();
                Thread.Sleep(500);
            }

            if (honeycrispAmount > 0) { 
            receiptOutput.Text += $"Honeycrisp    x{honeycrispAmount} @ {honeycrispPrice} ";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);
        }
            if (grannySmithAmount > 0)
            {
                receiptOutput.Text += $"\nGranny Smith  x{grannySmithAmount} @ {grannySmithPrice} ";
                receipt.Play();
                Refresh();
                Thread.Sleep(500);
            }
            receiptOutput.Text += $"\n\nSubtotal      {subtotal.ToString("C")}";
             receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\nTax           {taxAmount.ToString("C")}";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\nTotal         {totalAmount.ToString("C")}";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\n\nTendered      {change.ToString("C")}";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\nChange        {totalChange.ToString("C")}";
            receipt.Play();
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\n\nThank you for shopping at Pear";
            newOrderButton.Enabled = true;

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //clears everything to make a new order
            receiptOutput.Text = $"";
            subTotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            changeOutput.Text = $"";
            changeInput.Text = $"0";
            honeycrispInput.Text = $"0";
            grannySmithInput.Text = $"0";
            galaInput.Text = $"0";
            recipteTitle.Text = $"";
            newOrderButton.Enabled = false;
            printButton.Enabled = false;
            changeButton.Enabled = false;

        }
    }
}
