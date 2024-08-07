using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class MortgageCalculator
    {
        //Properties for values and calculations
        public decimal LoanAmount { get; set; }
        public decimal AnnualInterestRate { get; set; }
        public int NumberofMonths { get; set; }
        public decimal MonthlyPayment {  get; set; }
        public decimal RemainingBalance { get; set; }

        //Constructor
        public MortgageCalculator(decimal loanAmount, decimal annualInterestRate, int numberofMonths)
        {
            if (loanAmount <= 0)
                throw new ArgumentException("Loan amount must be greater than zero.");
            if (annualInterestRate <= 0)
                throw new ArgumentException("Annual interest rate must be greater than zero.");
            if (numberofMonths <= 0)
                throw new ArgumentException("Number of months must be greater than zero.");

            LoanAmount = loanAmount;
            AnnualInterestRate = annualInterestRate;
            NumberofMonths = numberofMonths;
            RemainingBalance = LoanAmount; // intial remaining balance
            MonthlyPayment = CalculateTotalMonthlyPayment();

        }

        public decimal CalculateTotalMonthlyPayment()
        {
            // Convert annual interest rate to monthly rate
            var monthlyRate = AnnualInterestRate / 1200;
            // Calculate the numerator of the formula
            var numerator = LoanAmount * monthlyRate;
            // Calculate the denominator of the formula
            var denominator = 1 - (decimal)Math.Pow((double)(1 + monthlyRate), -NumberofMonths);
            // Return the total monthly payment
            return numerator / denominator;
        }

        public decimal CalculateInterestPayment()
        {
            return RemainingBalance * AnnualInterestRate / 1200;
        }

        public decimal CalculatePrincipalPayment()
        {
            return MonthlyPayment - CalculateInterestPayment();
        }

        public void MakeMonthlyPayment()
        { 
            decimal principalPayment =  CalculatePrincipalPayment();
            RemainingBalance -= principalPayment;
        
        }
    }
}
