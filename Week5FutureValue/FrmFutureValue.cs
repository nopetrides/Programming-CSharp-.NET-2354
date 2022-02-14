using System;
using System.Windows.Forms;

namespace Week5FutureValue
{
	public partial class FrmFutureValue : Form
	{
		public FrmFutureValue()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
        {
			if (CheckUserEnteredValidData(out decimal monthlyInvestment, out decimal yearlyInterestRate, out int years))
            {
				SetFutureValueDisplay(CalculateFutureValue(monthlyInvestment, years, yearlyInterestRate));
			}
        }

		private bool CheckUserEnteredValidData(out decimal monthlyInvestment, out decimal yearlyInterestRate, out int years)
        {
			bool dataValid = true;
			// get the user input
			if (!Validator.TryParseDecimal(txtMonthlyInvestment.Text, "Monthly Investment", out monthlyInvestment))
			{
				txtMonthlyInvestment.Clear();
				dataValid = false;
			}

			if (!Validator.TryParseDecimal(txtYearlyInterestRate.Text, "Yearly Interest Rate", out yearlyInterestRate))
			{
				txtYearlyInterestRate.Clear();
				dataValid = false;
			}
			
			if (!Validator.TryParseInt(txtNumberOfYears.Text, "Number of Years to Invest", out years))
            {
				txtNumberOfYears.Clear();
				dataValid = false;
            }

			return dataValid;
		}

        /// <summary>
        /// This method calculates the future value by the monthly investment, interest rate and number of months investing
        /// uses a for loop
        /// </summary>
        /// <param name="monthlyInvestment"></param>
        /// <param name="months"></param>
        /// <param name="monthlyInterestRate"></param>
        /// <returns></returns>
        private static decimal CalculateFutureValue(decimal monthlyInvestment, int years, decimal yearlyInterestRate)
		{
			int months = years * 12;
			decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
			decimal futureValue = 0m;

			// calculates future value month by month up to the total number of years.
			for (int i = 0; i < months; i++)
			{
				futureValue = (futureValue + monthlyInvestment)
					* (1 + monthlyInterestRate);
			}

			return futureValue;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// When starting a new data entry, clear the last result
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearResult(object sender, EventArgs e)
		{
			txtFutureValue.Text = "";
		}

		private void SetFutureValueDisplay(decimal futureValue)
        {
			txtFutureValue.Text = futureValue.ToString("c");
			txtMonthlyInvestment.Focus();
        }
	}
}
