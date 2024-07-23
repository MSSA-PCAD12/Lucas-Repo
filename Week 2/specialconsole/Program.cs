using System;
using Spectre.Console;
using Spectre.Console.Cli;

namespace SpectreConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Spectre.Console to create a simple table
            var table = new Table();
            table.AddColumn("Name");
            table.AddColumn("Age");
            table.AddRow("Alice", "30");
            table.AddRow("Bob", "25");
            table.AddRow("Charlie", "35");

            AnsiConsole.Write(table);

            // Using Spectre.Console.Cli for a command-line interface
            var app = new CommandApp<MyCommand>();
            app.Run(args);
        }
    }

    public class MyCommand : Command<CommandSettings>
    {
        public override int Execute(CommandContext context, CommandSettings settings)
        {
            AnsiConsole.MarkupLine("[green]Hello, Spectre.Console![/]");
            return 0;
        }
    }
}
