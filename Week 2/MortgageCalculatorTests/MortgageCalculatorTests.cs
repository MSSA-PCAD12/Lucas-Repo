using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculator;

namespace MortgageCalculator.Tests
{
    [TestClass()]
    public class MortgageCalculatorTests
    {
        [TestMethod()]
        public void ValidInputsMortgageCalculatorTest()
        {
            // Arrange
            decimal loanAmount = 300000;
            decimal annualInterestRate = 5;
            int numberofMonths = 360;

            // Act
            MortgageCalculator calculator = new MortgageCalculator(loanAmount, annualInterestRate, numberofMonths);

            // Assert
            Assert.AreEqual(loanAmount, calculator.LoanAmount);
            Assert.AreEqual(annualInterestRate, calculator.AnnualInterestRate);
            Assert.AreEqual(numberofMonths, calculator.NumberofMonths);
            Assert.AreEqual(loanAmount, calculator.RemainingBalance);
        }
        [TestMethod()]
        [DataRow(-2, 5, 360)]
        [DataRow(600000, -6, 360)]
        [DataRow(900000, 5, -360)]
        public void ConstructorMortgageCalculatorTest2(int loanAmount, int annualInterestRate, int numberofMonths)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new MortgageCalculator(loanAmount, annualInterestRate, numberofMonths));

        }
        [TestMethod()]
        public void TotalMonthlyPaymentTest()
        {
            // Arrange
            MortgageCalculator calculator = new MortgageCalculator(300000, 5, 360);

            // Act
            decimal monthlyPayment = calculator.CalculateTotalMonthlyPayment();

            // Assert
            Assert.AreEqual(1610.46M, Math.Round(monthlyPayment, 2));
        }

        [TestMethod()]
        public void MakeMonthlyPaymentTest()
        {
            // Arrange
            MortgageCalculator calculator = new MortgageCalculator(300000, 5, 360);
            decimal initialBalance = calculator.RemainingBalance;

            // Act
            calculator.MakeMonthlyPayment();

            // Assert
            Assert.IsTrue(calculator.RemainingBalance < initialBalance);
        }
    }
}
