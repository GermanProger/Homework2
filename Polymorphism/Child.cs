using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Child : Parent
    {
        public Child()
        {
            IsVirtual = true;
        }

        public void SomeMethod()
        {
            if(IsVirtual)
            {
                Console.WriteLine("Child");
            }
            else
            {
                base.SomeMethod();
            }

        }
    }
}
