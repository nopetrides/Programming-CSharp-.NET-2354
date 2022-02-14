using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Invoice_Form
{
    public partial class frmBookFeeCalculator : Form
    {
        /// <summary>
        /// WARNING *enum values are multiplied by 0.01 for final calculation fee
        /// </summary>
        public enum CalculatorTypesWithFeeInCents
        {
            Unknown = 0,
            NonFiction = 70,
            Fiction = 12
        }

        private CalculatorTypesWithFeeInCents currentBookType;

        public frmBookFeeCalculator()
        {
            InitializeComponent();
        }

        private void frmFictionBookFeeCalculator_Shown(object sender, EventArgs e)
        {
            SetupFormForType();
        }

        /// <summary>
        /// Initializes a form for a specific type of calculator
        /// </summary>
        private void SetupFormForType()
        {
            if (currentBookType == CalculatorTypesWithFeeInCents.Unknown)
            {
                MessageBox.Show("No Calculator Type Set!");
                Close();
                return;
            }
            decimal currentBookFee = (int)currentBookType * 0.01m;

            lblFeeRate.Text = String.Format("At {0:c} / day per book", currentBookFee);

            switch (currentBookType)
            {
                case CalculatorTypesWithFeeInCents.NonFiction:
                    this.Text = "Non Fiction Book Fee Calculator";
                    break;
                case CalculatorTypesWithFeeInCents.Fiction:
                    this.Text = "Fiction Book Fee Calculator";
                    break;
                default:
                    // we should never get here
                    this.Text = "Unknown Calculator";
                    break;
            }

            double calculatedCircumferece = 2 * Math.PI;

            txtTemp.Text = Math.PI.ToString();
        }

        public void SetupForType(CalculatorTypesWithFeeInCents type)
        {
            currentBookType = type;
        }

    }
}
