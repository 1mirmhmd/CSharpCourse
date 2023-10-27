namespace _07_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Halil";
            customer.LastName = "Can";
            customer.City = "Sivas";
            Customer customer1 = new Customer { Id = 2, FirstName = "Murat", LastName = "Kulu", City = "Ordu" };
            Console.WriteLine(customer1.FirstName);
        }
    }


}