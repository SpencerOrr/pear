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
        double galaPrice = 2.5;
        double honeycrispPrice = 4;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                galaAmount = Convert.ToDouble(galaInput.Text);
                honeycrispAmount = Convert.ToDouble(honeycrispInput.Text);
                grannySmithAmount = Convert.ToDouble(grannySmithInput.Text);
                subtotal = galaAmount * galaPrice + honeycrispAmount * honeycrispPrice + grannySmithAmount * grannySmithPrice;
                taxAmount = subtotal * taxRate;
                totalAmount = taxAmount + subtotal;

                subTotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalAmount.ToString("C")}";
            }
            catch
            {
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
                change = Convert.ToDouble(changeInput.Text);
                totalChange = change - totalAmount;
                changeOutput.Text = $"{totalChange.ToString("C")}";
            }
            catch 
            {
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
            recipteTitle.Text = $"              Pear";
           
            Refresh();
            Thread.Sleep(500);
             
            receiptOutput.Text += $"\n\n\n\n        order number 4092 ";
            receiptOutput.Text += $"\n\n        September 29, 2022 ";

            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += $"\nGala          x{galaAmount} @ {galaPrice} ";

            Refresh();
            Thread.Sleep(500);
            receiptOutput.Text += $"\nHoneycrisp    x{honeycrispAmount} @ {honeycrispPrice} ";
            receiptOutput.Text += $"\nGranny Smith  x{grannySmithAmount} @ {grannySmithPrice} ";

        }
    }
}
