namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >=0; i=i-2)
            {
                Console.WriteLine(i);
            }
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}