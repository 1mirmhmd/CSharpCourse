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
            else
            {
                Console.WriteLine("Number is not 10");
            }
            // Single line if 
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

        }
    }
}