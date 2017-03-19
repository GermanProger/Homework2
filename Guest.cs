using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    /// <summary>
    /// Guest can autorize only typing username
    /// </summary>
    public class Guest : User
    {
        public override void SignIn()
        {
            Autorizator.Instance.GetRequestFromGuest(this);
        }
    }
}
