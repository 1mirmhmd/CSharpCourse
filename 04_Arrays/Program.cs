namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Ali", "Müslmüm", "Nadir" };
            string[] students1 = { "Hilal", "Derin", "Sıla" };
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }
            string[,] regions = new string[4, 2] {
                {"İstanbul","İzmit" },
                {"Ankara","Konya" },
                {"Antalya","Adana" },
                {"Rize","Trabzon" } 
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }
        }
    }
}