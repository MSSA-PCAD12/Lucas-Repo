using System;

namespace Primitives
{
    internal class Program
    {
        static int l;
        static void Main(string[] args)
        {
            //The next two statements assign a new enum Color value to Console Properties, changing the Console color
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;




            int i = 10; 
            int j = 10;
            int k = 12;

            Console.WriteLine($"i is {i}; j is {j * 2} ;k is {k + 3}; l is {l}");

            j = i;
            i = 20;

            Console.WriteLine($"i is {i}; j is {j} ;k is {k}; l is {l}");


            int intmax = int.MaxValue;
            int intmin = int.MinValue;

            Console.WriteLine($"int(signed 4 bytes) can store max:{intmax} and min{intmin}");

            int hexint = 0xA0;
            int binint = 0b_1110_0011;
            int easytoreadint = 33_320_000;
            Console.WriteLine($"int with different encoding can store hexint: {hexint} and binint{binint}; {easytoreadint}");

            byte b =255;
            byte c = 5;
            var d = b + c;

            int result = intmax + 1;
            Console.WriteLine($"What happens when we add 1 to intMax? {result}");

            float floatVar = 1234.567f;
            double doublevar = 1234.567;
            decimal decimalVar = 1234.456m;

            var guessVar = 1234.567;
            // implicit converstion
            byte varB = 100;
            int varint = varB;

            //explicit 
            byte varC = (byte) intmax;
            Console.WriteLine("implicit conversion(no loss of data):{varB};Explicit conversion (potential loss of data):{varC}");
            var resultoOfconversion = Convert.ToDecimal("1.234");

            bool IsHappy = false;
            bool IsHappyReversed = !IsHappy;

            bool IsEqual = (1 == 1);
            bool IsNotEqual = (1 != 1);
            //bool IsNotEqual = (2 >= 1);
            //bool IsNotEqual = (2 > 1);
            //bool IsNotEqual = (2 < 1);

            //AND short circut ev
            bool truthTableTandT = (true && true); //true
            bool truthTableTandF = (true && false); //false
            bool truthTableFandF = (false && false); //false
            bool truthTableFandT = (false && true); //false

            //OR
            bool truthTableTorT = (true || true); //true
            bool truthTableTorF = (true || false); //true
            bool truthTableForF = (false || false); //false
            bool truthTableForT = (false || true); //true

            //XOR exclusive OR -- there can be only one true
            bool truthTableTxorT = (true ^ true); //false
            bool truthTableTxorF = (true ^ false); //true
            bool truthTableFxorF = (false ^ false); //false
            bool truthTableFxorT = (false ^ true); //true

            //AND Always Evaluate both sides of the operator
            bool truthTableTandT2 = (true & true); //true
            bool truthTableTandF2 = (true & false); //false
            bool truthTableFandF2 = (false & false); //false
            bool truthTableFandT2 = (false & true); //false

            //OR Always Evaluate both sides of the operator
            bool truthTableTorT2 = (true  | true); //true
            bool truthTableTorF2 = (true  | false); //true
            bool truthTableForF2 = (false | false); //false
            bool truthTableForT2 = (false | true); //true


            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

            
           

        }
    }
}
