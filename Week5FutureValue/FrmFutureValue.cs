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

		/// <summary>
		/// Called when the user activates the calculate button.
		/// The calculate button can activate if the user clicks it with a mouse,
		/// or if the user selects it with the tab index and presses enter
		/// or if the user uses the access key to select the button with its hotkey
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCalculateButtonPressed(object sender, EventArgs e)
        {
			if (CheckUserEnteredValidData(out decimal monthlyInvestment, out decimal yearlyInterestRate, out int years))
			{
				SetFutureValueDisplay(CalculateFutureValue(monthlyInvestment, years, yearlyInterestRate));
			}
		}

		/// <summary>
		/// Validates data and spits out the parsed values
		/// </summary>
		/// <param name="monthlyInvestment"></param>
		/// <param name="yearlyInterestRate"></param>
		/// <param name="years"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Called when the user activates the Exit button on the form
		/// The Exit button can activate if the user clicks it with a mouse,
		/// or if the user selects it with the tab index and presses enter
		/// or if the user uses the access key to select the button with its hotkey
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnExitButtonPressed(object sender, EventArgs e)
        {
			Close();
        }

		/// <summary>
		/// Sets the form values with calculated values
		/// Switches Control to the txtMonthlyInvestment
		/// </summary>
		/// <param name="futureValue"></param>
		private void SetFutureValueDisplay(decimal futureValue)
        {
			txtFutureValue.Text = futureValue.ToString("c");
			if (btnExit.CanFocus)
            {
				btnExit.Focus();
			}
        }
    }
}
