using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Week_Assignment
{
    class MethodOverride
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.show();
            Console.ReadKey();
        }
    }
    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()
        {
            Console.WriteLine("Sub class override show method");
        }
    }
    
}
