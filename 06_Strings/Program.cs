namespace _06_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringIntro();
            string sentence = "My name is 1mirmhmd";
            var result = sentence.Length;
            var resul1 = sentence.Clone();

            sentence = "My name is mirmhmd";

            bool result2 = sentence.EndsWith("b");
            bool result3 = sentence.StartsWith("My name");

            var result4 = sentence.IndexOf("name");
            var result5 = sentence.LastIndexOf(" ");
            var result6 = sentence.Insert(0, "Hello, ");
            var result7 = sentence.Substring(3, 4);
            var result8 = sentence.ToUpper();
            var result9 = sentence.ToLower();
            var result10 = sentence.Replace(" ", "-");
            var result11 = sentence.Remove(2, 4);
            Console.WriteLine(result11);
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