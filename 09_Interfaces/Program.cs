namespace _09_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntefacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SQLServerCustomerDal(),
                new OracleServerCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            // Interface'ler new'lenemez
            IPerson person = new Customer();
            person.FirstName = "Ali";


        }

        private static void Demo()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new SQLServerCustomerDal());
        }

        private static void IntefacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Aziz", LastName = "Han", Address = "Ağrı" });
            Student student = new Student { Id = 1, FirstName = "Kamil", LastName = "Birol", Department = "Computer Science" };
            personManager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}