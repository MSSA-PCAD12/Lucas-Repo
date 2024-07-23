namespace ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reference type = Array
            //value type = System.DateTime
            int[] i = [1, 2, 3];
            ChangeReferenceType(i);
            Console.WriteLine(i[0]);

            int j = 10;
            ChangeValueType(ref j);
            Console.WriteLine(j);


            DateTime someDate = new DateTime(year: 1975, month: 7, day: 21);
            Console.WriteLine(someDate.DayOfWeek);

          
            Console.WriteLine($"on {someDate.AddYears(21)}, which is a {someDate.AddYears(21).DayOfWeek}");

            DateTime today = DateTime.Today;
            var result = today - someDate;
            DateTime iHopeIcanSeeIt = today.Add(result);
            Console.WriteLine(iHopeIcanSeeIt.ToString("yyyy MMMM dd"));


            if (today.DayOfWeek == DayOfWeek.Wednesday)
            { 
                Console.WriteLine("Its Wednesday"); 
            }
            else
            {
                Console.WriteLine("Its not Wednesday");
            }
            switch (today.DayOfWeek)
            {

                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Its Weekday");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Its Weekend");
                    break;
                default:
                    break;
            }

        }

        static void ChangeReferenceType(int[] input)
        {
            input[0] = 99;
        }
        static void ChangeValueType(ref int input)
        {
            input = 99;
        }



    }
}






