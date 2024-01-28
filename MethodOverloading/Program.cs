namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sum = Add(3, 4);
            Console.WriteLine(sum);

            var doubleSum = Add(8.1, 5.9);
            Console.WriteLine(doubleSum);

            var decimalSum = Add(7.54m, 1.98m);
            Console.WriteLine(decimalSum);



            var dollarOne = Add(3, 2, true);
            Console.WriteLine(dollarOne);

            var dollarTwo = Add(0, 1, true);
            Console.WriteLine(dollarTwo);

            var dollarThree = Add(8, 8, true);
            Console.WriteLine(dollarThree);

            var dollarFour = Add(4, 4, false);
            Console.WriteLine(dollarFour);


        }

        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static double Add(double a, double b)
        {
            return (a + b);
        }
        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }

        public static string Add(int a, int b, bool yesDollar)
        {
            if (yesDollar && (a + b != 1))
            {
                return ($"{a + b}$");
            }
            else if (yesDollar && (a + b) == 1)
            {
                return ($"{a + b}$");
            }
            else
            {
                return ("Thats good money.");
            }
        }
    }
}
