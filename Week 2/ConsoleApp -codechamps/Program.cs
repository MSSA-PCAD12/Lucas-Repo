using CodeChamps;

namespace ConsoleApp__codechamps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a string:");
            string input = Console.ReadLine();
            Console.WriteLine($"{VowelCount.CountVowel(input)} vowels");
        }
    }
}
