using System;
using System.Windows.Forms;

namespace Week2_Invoice_Form
{
    public partial class frmInvoiceTotal : Form
    {
        private frmBookFeeCalculator fictionCalcForm;

        private int totalNumberOfInvoices;
        private decimal totalCostOfInvoices;

        public frmInvoiceTotal()
        {
            InitializeComponent();

            fictionCalcForm = new frmBookFeeCalculator();
        }

        /// <summary>
        /// Fired when the Exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hide the form
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal? subtotal = Validator.TryGetDecimalValueFromString(txtSubtotalEntry.Text);
            if (!subtotal.HasValue)
            {
                MessageBox.Show("No valid input detected.");
                return;
            }

            decimal successParseSubtotal = subtotal.Value;
            decimal discountPercent = 0m;

            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100)
            {
                discountPercent = .10m;
            }


            decimal discountAmount = successParseSubtotal * discountPercent; 
            decimal invoiceTotal = successParseSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            totalNumberOfInvoices++;
            totalCostOfInvoices += invoiceTotal;
            decimal average = totalCostOfInvoices / totalNumberOfInvoices;

            txtTotalInvoices.Text = totalNumberOfInvoices.ToString();
            txtTotalInvoiceCost.Text = totalCostOfInvoices.ToString("c");
            txtInvoiceAverage.Text = average.ToString("c");

            txtSubtotalEntry.Focus();
        }

        private void btnOpenFiction_Click(object sender, EventArgs e)
        {
            fictionCalcForm.SetupForType(frmBookFeeCalculator.CalculatorTypesWithFeeInCents.Fiction);
            fictionCalcForm.ShowDialog();
        }

        private void btnOpenNonFiction_Click(object sender, EventArgs e)
        {
            fictionCalcForm.SetupForType(frmBookFeeCalculator.CalculatorTypesWithFeeInCents.NonFiction);
            fictionCalcForm.ShowDialog();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            totalNumberOfInvoices = 0;
            totalCostOfInvoices = 0;

            txtTotalInvoices.Text = "";
            txtTotalInvoiceCost.Text = "";
            txtInvoiceAverage.Text = "";
        }

        private void txtSubtotalEntry_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubtotalEntry.Text))
            {
                lblWarningLabel.Show();
            }
            else if (Validator.IsValidDecimal(txtSubtotalEntry.Text))
            {
                // disable any warnings
                lblWarningLabel.Hide();
            }
            else
            {
                // enable the warnings
                lblWarningLabel.Show();
            }
        }
    }
}
