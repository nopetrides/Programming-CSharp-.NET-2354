using System;
using System.Windows.Forms;

namespace Week5FutureValue
{
	public partial class FrmFutureValue : Form
	{

		private bool groupInvesting;

		public enum InterestType
		{
			None = 0,
			Fixed = 'F',
			Compound = 'T'
		}

		public FrmFutureValue()
		{
			InitializeComponent();
		}

		private void FrmFutureValue_Load(object sender, EventArgs e)
		{
			ChangeVisibilityOfNumberInvesting();
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
			try
			{
				if (CheckUserEnteredValidData(out decimal monthlyInvestment, out decimal interestRate, out int years, out int peopleInvesting, out InterestType interestType))
				{
					SetFutureValueDisplay(CalculateFutureValue(monthlyInvestment, interestRate, years, peopleInvesting, interestType));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\nError of type: " + ex.GetType() + "\n\nStack trace:\n\n" + ex.StackTrace, "Error Encountered");
			}
		}

		/// <summary>
		/// Validates data and spits out the parsed values
		/// </summary>
		/// <param name="monthlyInvestment"></param>
		/// <param name="interestRate"></param>
		/// <param name="years"></param>
		/// <returns></returns>
		private bool CheckUserEnteredValidData(
			out decimal monthlyInvestment,
			out decimal interestRate,
			out int years,
			out int peopleInvesting,
			out InterestType interestType)
		{
			bool dataValid = true;
			// get the user input

			if (!groupInvesting)
			{
				peopleInvesting = 1;
			}
			else if (!Validator.TryParseInt(txtNumberInvesting.Text, "Number Investing", out peopleInvesting))
			{
				txtNumberInvesting.Clear();
				dataValid = false;
			}

			if (!Validator.TryParseDecimal(txtMonthlyInvestment.Text, "Monthly Investment", out monthlyInvestment))
			{
				txtMonthlyInvestment.Clear();
				dataValid = false;
			}

			if (!Validator.TryParseDecimal(txtInterestRate.Text, "Yearly Interest Rate", out interestRate))
			{
				txtInterestRate.Clear();
				dataValid = false;
			}

			if (!Validator.TryParseInterestType(txtInterestType.Text, "Interest Type", out interestType))
			{
				txtInterestType.Clear();
				dataValid = false;
			}

			if (!Validator.ValidateYearsToInvest(txtNumberOfYears.Text, "Number of Years to Invest", out years))
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
		private static decimal CalculateFutureValue(decimal monthlyInvestment, decimal interestRate, int years, int peopleInvesting, InterestType interestType)
		{
			int months = years * 12;
			decimal monthlyInterestRate = interestRate / 12 / 100;
			decimal futureValue = 0m;

			// calculates future value month by month up to the total number of years.
			// TODO: calculation differs based on interestType
			for (int i = 0; i < months; i++)
			{
				futureValue = (futureValue + monthlyInvestment * peopleInvesting)
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
			if (txtFutureValue == null)
            {
				ErrorHandler.ThrowErrorMessage("Could not set text on future value textbox because the textbox is null!");
            }
			txtFutureValue.Text = futureValue.ToString("c");
			if (btnExit.CanFocus)
			{
				btnExit.Focus();
			}
		}

		private void OnGroupInvestmentCheckBoxChanged(object sender, EventArgs e)
		{
			ChangeVisibilityOfNumberInvesting();
		}

		private void ChangeVisibilityOfNumberInvesting()
		{
			groupInvesting = GroupInvestmentCheckBox.Checked;
			lblNumberInvesting.Visible = groupInvesting;
			txtNumberInvesting.Visible = groupInvesting;
		}

	}
}
