using System.Numerics;

namespace Week_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //string namePrompt = "Please enter your name: ";
            //Console.WriteLine(namePrompt);
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //var favoriteColorPrompt = "Please enter your favorite color: ";
            //Console.WriteLine(favoriteColorPrompt);
            //var favoriteColor = Console.ReadLine();
            //Console.WriteLine("Your favorite color is: " + favoriteColor);

            //Console.WriteLine(string.Format("Hello {0}! Your favorite color is: {1}", name, favoriteColor));
            //Console.WriteLine($"Hello {name}! Your favorite color is: {favoriteColor}");

            var carData = "1965|Ford|Mustang|75231.9|Blue";
            Console.WriteLine($"Length: {carData.Length}");

            Console.WriteLine($"Substring 10: {carData.Substring(10)}");
            Console.WriteLine($"Substring 17: {carData.Substring(17)}");

            Console.WriteLine($"Substring 10, 7: {carData.Substring(10, 7)}");

            var trailingSpaces = "1994|Ford|Mustang|175231.9|Green   ";
            Console.WriteLine($"Trailing Spaces Length: {trailingSpaces.Length}");
            Console.WriteLine($"Trailing Spaces Length Trimmed: {trailingSpaces.Trim().Length}");

            var updatedCar = carData.Replace("1965", "1985");
            updatedCar = updatedCar.Replace("Ford", "Chevy");
            updatedCar = updatedCar.Replace("Mustang", "Camaro");
            Console.WriteLine($"Your new car data is: {updatedCar}");

            var adjustedCarData = carData.ToUpper();
            Console.WriteLine($"Car Data: {adjustedCarData}");
            Console.WriteLine($"Car Data: {adjustedCarData.ToLower()}");

            //boolean

            int number1 = 10, number2 = 10;

            Console.WriteLine($"{number1} == {number2}, {number1 == number2}");
            number2 = 50;
            Console.WriteLine($"{number1} <= {number2}, {number1 <= number2}");
            Console.WriteLine($"{number1} >= {number2}, {number1 >= number2}");
            Console.WriteLine($"{number1} != {number2}, {number1 != number2}");
            Console.WriteLine($"{number1} < {number2}, {number1 < number2}");
            Console.WriteLine($"{number1} > {number2}, {number1 > number2}");

            bool isFord = carData.Contains("ford", StringComparison.OrdinalIgnoreCase);
            bool isFord2 = carData.ToUpper().Contains("FORD");
            Console.WriteLine($"Is a Ford: {isFord}");
            Console.WriteLine($"Is a Ford: {isFord2}");

            var startsWith1 = carData.StartsWith("1"); //cars from the 1900's only.
            var startsWith2 = carData.StartsWith("2"); //cars from the 2000's only 
            Console.WriteLine($"Is a 1900s car: {startsWith1}");
            Console.WriteLine($"Is a 2000s car: {startsWith2}");

            var hasPositionalDataGT = carData.LastIndexOf('n') >= 15;  //contains an n after position 15
            var hasPositionalDataLT = carData.LastIndexOf('o') < 15;   //contains no o's after position 14
            Console.WriteLine($"Has an 'n' at position 15 or after position 15: {hasPositionalDataGT}");
            Console.WriteLine($"Does not have an 'o' after position 14: {hasPositionalDataLT}");

            var anotherCar = carData;
            var yetAnotherCar = carData.Replace("Ford", "Chevy");
            var isSameCar = anotherCar.Equals(carData);
            var isSameCar2 = yetAnotherCar.Equals(carData);
            Console.WriteLine($"anotherCar is equal to carData: {isSameCar}");
            Console.WriteLine($"yetAnotherCar is equal to carData: {isSameCar2}");

            bool isHungry = true;
            bool haveMoney = false;
            bool haveGiftCard = true;
            var isTired = true;
            var haveToWork = true;

            var getTakeout = isHungry && haveMoney;
            Console.WriteLine($"Should Get Takeout: {getTakeout}");

            var sleeping = isTired && !haveToWork;
            Console.WriteLine($"Are you sleeping: {sleeping}");

            getTakeout = isHungry && (haveMoney || haveGiftCard);
            Console.WriteLine($"Should Get Takeout: {getTakeout}");

            string string1 = null;
            var string2 = string.Empty;
            var string3 = "  ";
            Console.WriteLine($"string1: {string1}");
            Console.WriteLine($"string2: {string2}");
            Console.WriteLine($"string3: {string3}");

          

            Console.WriteLine($"string 1 null or whitespace: {string.IsNullOrWhiteSpace(string1)}");
            Console.WriteLine($"string 2 null or whitespace: {string.IsNullOrWhiteSpace(string2)}");
            Console.WriteLine($"string 3 null or whitespace: {string.IsNullOrWhiteSpace(string3)}");








        }
    }
}
