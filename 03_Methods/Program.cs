namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            int number1 = 20;
            int number2 = 100;
            // ref ve out keywordu referans tanımlamak için kullanılır. ref kullanıldığında değişkende değer tanımlanmalı, out'ta ise tanımlamaya gerek yok.
            var result1 = Add2(ref number1, number2);
            var result = Add1(120, 120);
            Console.WriteLine(result1);
            Console.WriteLine(Add3(1, 2, 3, 4, 5));
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add1(int number1 = 20, int number2 = 10)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add2(ref int number1, int number2)
        {
            return number1 + number2;
        }

        // Method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add3( int number,params int[] numbers) // Tekli parametre her zaman en önde eklenmeli
        {
            return numbers.Sum();
        }
    }
}