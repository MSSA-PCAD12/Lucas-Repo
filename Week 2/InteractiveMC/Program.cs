using System;
using Spectre.Console;

namespace InteractiveMortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clear the console
            Console.Clear();

            // Display a welcome message with styling
            AnsiConsole.Markup("[bold yellow]Welcome to the Interactive Mortgage Calculator![/]\n");

            // Get the loan amount from the user
            decimal loanAmount = AnsiConsole.Ask<decimal>("Enter the [green]loan amount[/]:");

            // Get the annual interest rate from the user
            decimal annualInterestRate = AnsiConsole.Ask<decimal>("Enter the [green]annual interest rate[/] (percentage):");

            // Get the number of months for the loan term from the user
            int numberOfMonths = AnsiConsole.Ask<int>("Enter the [green]loan term[/] (in months):");

            // Create an instance of the MortgageCalculator using the provided details
            var calculator = new MortgageCalculator.MortgageCalculator(loanAmount, annualInterestRate, numberOfMonths);

            // Calculate the monthly payment using the MortgageCalculator instance
            decimal monthlyPayment = calculator.CalculateTotalMonthlyPayment();

            // Display the calculated monthly payment with styling
            AnsiConsole.MarkupLine($"[bold yellow]Monthly Payment:[/] {monthlyPayment:C}\n");

            // Create a table to display loan details
            var table = new Table();
            table.AddColumn("Property");
            table.AddColumn("Value");
            table.AddRow("Loan Amount", loanAmount.ToString("C"));
            table.AddRow("Annual Interest Rate", $"{annualInterestRate}%");
            table.AddRow("Loan Term", $"{numberOfMonths} months");
            table.AddRow("Monthly Payment", monthlyPayment.ToString("C"));

            // Write the table to the console
            AnsiConsole.Write(table);

            
        }
    }
}
