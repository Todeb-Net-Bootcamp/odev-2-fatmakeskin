using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Week_Assignment
{
    class AbstractClass
    {
        static void Main(string[] args) 
        {
            Database database = new MySql();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database.Add();
            database.Delete();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Mysql");
        }
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by SqlServer");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Oracle");
        }
    }

}
