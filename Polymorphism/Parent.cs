using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Polymorphism
{
    public class Parent
    {
        public bool IsVirtual { get; set; }

        public void SomeMethod()
        {
            if (IsVirtual)
            {
                Type type = this.GetType();
                //MethodInfo method = type.GetMethod("SomeMethod");
                Console.WriteLine(type.InvokeMember("SomeMethod", BindingFlags.InvokeMethod, null, Activator.CreateInstance(type), null));
            }
            else
            {
                Console.WriteLine("Parent");
            }

        }
    }
}
