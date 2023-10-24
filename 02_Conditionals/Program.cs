namespace _02_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10 and 20");
            }
            // Single line if 
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 10");
                    break;
                default:
                    Console.WriteLine("Number is not 10 and 20");
                    break;
            }

        }
    }
}