namespace _01_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Value Types 
            int number1 = -2147483648;
            int number2= 2147483647;
            long number3 = 9223372036854775807;
            long number4 = -9223372036854775808;

            Console.WriteLine("Number 1 is {0} ",number1);
        }
    }
}