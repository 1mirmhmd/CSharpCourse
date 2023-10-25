namespace _06_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringIntro();
            string sentence = "My name is 1mirmhmd";
        }

        private static void StringIntro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2;
            //Best Practice

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}