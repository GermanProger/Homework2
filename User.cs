using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    public class User
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }

        /// <summary>
        /// Tries to autorize
        /// </summary>
        public virtual void Autorize()
        {
            Console.WriteLine("Please, enter Username");
            Username = Console.ReadLine();
            Console.WriteLine("Please, enter Password");
            Password = Console.ReadLine();
        }
    }
}
