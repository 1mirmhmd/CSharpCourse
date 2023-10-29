Person[] person = new Person[3]
{
    new Customer{FirstName="Aziz"},
    new Student{FirstName="Mutlu"},
    new Person{FirstName="Hayat"}

};
foreach (var isim in person)
{
    Console.WriteLine(isim.FirstName); 
}
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer:Person
{
    public string City { get; set; }
}
class Student:Person
{
    public string Department { get; set; }

}
