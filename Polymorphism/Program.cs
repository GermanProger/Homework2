using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Parent pc = new Child();
            p.SomeMethod();
            c.SomeMethod();
            pc.SomeMethod();
            Console.ReadLine();
        }
    }
}
