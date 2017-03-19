using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    /// <summary>
    /// Admin can autorize typing username, password and secret key
    /// </summary>
    public class Admin : User
    {
        public string SecretKey { get; private set; }
        /// <summary>
        /// autorizes like base class user + must enter a secret key
        /// </summary>
        public override void Autorize()
        {
            base.Autorize();
            Console.WriteLine("Please, enter Secret Key");
            SecretKey = Console.ReadLine();
        }
    }
}
