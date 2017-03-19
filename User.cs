using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    public class User
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        /// <summary>
        /// Tries to sign in
        /// </summary>
        public virtual void SignIn()
        {
            Autorizator.Instance.GetRequestFromUser(this);
        }
        /// <summary>
        /// overloading operator == for comfort
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(User x, User y)
        {
            return (x.Username.Equals(y.Username) && x.Password.Equals(y.Password)) ? true : false;
        }

        public static bool operator !=(User x, User y)
        {
            return !(x == y);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return this == (User)obj;
            }
            catch
            {
                return false;
            }
        }
    }
}
