IWork[] works = new IWork[3]
{
    new Worker(),
    new Manager(),
    new Robot()
};
foreach (var work in works)
{
    work.Work();
}

interface IWork
{
    void Work();
}
interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}
class Manager : IWork, IEat
{
    public void Eat()
    {
        Console.WriteLine("")
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWork, ISalary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWork
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}