namespace _01_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Value Types
            double double_ = 10.4;
            decimal number5 = 10;
            char character = 'A';
            bool condition = false;
            byte byteNumber = 255;
            short number = 32767;
            short number_ = -32768;
            int number1 = -2147483648;
            int number2= 2147483647;
            long number3 = 9223372036854775807;
            long number4 = -9223372036854775808;
            var number6 = 10;
            number6 = 'A';
            //number6 = "A";

            Console.WriteLine("Number  is {0} ", byteNumber);
            Console.WriteLine("Number 1 is {0} ", number_);
            Console.WriteLine("Number 2 is {0} ",number);
            Console.WriteLine("Number 3 is {0} ",number1);
            Console.WriteLine("Number 4 is {0} ", number2);
            Console.WriteLine("Number 5 is {0} ", number3);
            Console.WriteLine("Number 6 is {0} ", number4);
            Console.WriteLine("Number 7 is {0} ", double_);
            Console.WriteLine("Character is {0} ", (int)character);
            Console.WriteLine(number6);
            Console.WriteLine((int)Days.Friday);



        }
    }
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday // İndis numaraları değiştirilebilir
    }
}