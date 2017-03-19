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
        public string SecretKey { get; set; } = "";
        /// <summary>
        /// tries to sign in like base class user + must enter a secret key
        /// </summary>
        public override void SignIn()
        {
            Autorizator.Instance.GetRequestFromAdmin(this);
        }

        public static bool operator ==(Admin x, Admin y)
        {
            return (x.SecretKey == y.SecretKey) && ((User)x == (User)y) ? true : false;
        }

        public static bool operator !=(Admin x, Admin y)
        {
            return !(x == y);
        }
    }
}
