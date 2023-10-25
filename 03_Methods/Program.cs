namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add1(120, 120);
            Console.WriteLine(result);
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add1 (int number1=20, int number2=10)
        {
            var result = number1+number2;
            return result;
        }
    }
}