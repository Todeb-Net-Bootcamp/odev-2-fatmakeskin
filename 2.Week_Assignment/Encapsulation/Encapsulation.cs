using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Week_Assignment
{
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Fatma";
        }
    }
    class Customer
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return "Bayan" + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
