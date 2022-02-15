
namespace Week5FutureValue
{
	partial class FrmFutureValue
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberInvesting = new System.Windows.Forms.Label();
            this.txtNumberInvesting = new System.Windows.Forms.TextBox();
            this.GroupInvestmentCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterestType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.AutoSize = true;
            this.lblMonthlyInvestment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(13, 99);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(164, 23);
            this.lblMonthlyInvestment.TabIndex = 3;
            this.lblMonthlyInvestment.Text = "&Monthly Investment";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interestRateLabel.Location = new System.Drawing.Point(12, 142);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(120, 23);
            this.interestRateLabel.TabIndex = 5;
            this.interestRateLabel.Text = "&Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Number of Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Future Value";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(183, 99);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(214, 30);
            this.txtMonthlyInvestment.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInterestRate.Location = new System.Drawing.Point(183, 142);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(214, 30);
            this.txtInterestRate.TabIndex = 6;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfYears.Location = new System.Drawing.Point(183, 214);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(214, 30);
            this.txtNumberOfYears.TabIndex = 10;
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFutureValue.Location = new System.Drawing.Point(183, 253);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(214, 30);
            this.txtFutureValue.TabIndex = 12;
            this.txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(17, 299);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 41);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.OnCalculateButtonPressed);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(231, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 41);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.OnExitButtonPressed);
            // 
            // lblNumberInvesting
            // 
            this.lblNumberInvesting.AutoSize = true;
            this.lblNumberInvesting.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberInvesting.Location = new System.Drawing.Point(13, 55);
            this.lblNumberInvesting.Name = "lblNumberInvesting";
            this.lblNumberInvesting.Size = new System.Drawing.Size(148, 23);
            this.lblNumberInvesting.TabIndex = 1;
            this.lblNumberInvesting.Text = "&Number Investing";
            // 
            // txtNumberInvesting
            // 
            this.txtNumberInvesting.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumberInvesting.Location = new System.Drawing.Point(183, 55);
            this.txtNumberInvesting.Name = "txtNumberInvesting";
            this.txtNumberInvesting.Size = new System.Drawing.Size(214, 30);
            this.txtNumberInvesting.TabIndex = 2;
            // 
            // GroupInvestmentCheckBox
            // 
            this.GroupInvestmentCheckBox.AutoSize = true;
            this.GroupInvestmentCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupInvestmentCheckBox.Location = new System.Drawing.Point(13, 12);
            this.GroupInvestmentCheckBox.Name = "GroupInvestmentCheckBox";
            this.GroupInvestmentCheckBox.Size = new System.Drawing.Size(167, 27);
            this.GroupInvestmentCheckBox.TabIndex = 0;
            this.GroupInvestmentCheckBox.Text = "&Group Investment";
            this.GroupInvestmentCheckBox.UseVisualStyleBackColor = true;
            this.GroupInvestmentCheckBox.CheckedChanged += new System.EventHandler(this.OnGroupInvestmentCheckBoxChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Interest &Type";
            // 
            // txtInterestType
            // 
            this.txtInterestType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInterestType.Location = new System.Drawing.Point(183, 178);
            this.txtInterestType.Name = "txtInterestType";
            this.txtInterestType.Size = new System.Drawing.Size(214, 30);
            this.txtInterestType.TabIndex = 8;
            // 
            // FrmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(429, 389);
            this.Controls.Add(this.txtInterestType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupInvestmentCheckBox);
            this.Controls.Add(this.txtNumberInvesting);
            this.Controls.Add(this.lblNumberInvesting);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Name = "FrmFutureValue";
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.FrmFutureValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMonthlyInvestment;
		private System.Windows.Forms.Label interestRateLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMonthlyInvestment;
		private System.Windows.Forms.TextBox txtInterestRate;
		private System.Windows.Forms.TextBox txtNumberOfYears;
		private System.Windows.Forms.TextBox txtFutureValue;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberInvesting;
        private System.Windows.Forms.TextBox txtNumberInvesting;
        private System.Windows.Forms.CheckBox GroupInvestmentCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterestType;
    }
}

