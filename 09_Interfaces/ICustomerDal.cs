using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SQLServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Deleted");

        }

        public void Update()
        {
            Console.WriteLine("SQL Server Updated");


        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
        
    }
}
