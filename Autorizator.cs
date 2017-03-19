using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    /// <summary>
    /// Autorizator accepts/rejects authorization and 
    /// records all the authorization actions 
    /// </summary>
    public class Autorizator
    {
        /// <summary>
        /// holds all the authorization actions
        /// </summary>
        private List<string> _history = new List<string>();
        private List<Admin> _admins = new List<Admin>()
        {
            new Admin() { Username = "admin", Password = "apass", SecretKey = "adm" }, 
            new Admin() { Username = "admin1", Password = "passa", SecretKey = "nimda" }
        };
        private List<User> _users = new List<User>()
        {
            new Guest() { Username = "user" },
            new Guest() { Username = "user123" },
            new Editor() { Username = "editor", Password = "epass" }
        };
        #region Singleton
        private static Autorizator _instance;

        private Autorizator() { }

        public static Autorizator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Autorizator();
                }
                return _instance;
            }
        }
        #endregion

        /// <summary>
        /// Checks whether user passed autorization or not
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true, if autorization is passed</returns>
        public bool IsAcceptable(User user)
        {
            if(user.GetType() == typeof(Admin))
            {
                foreach (Admin a in _admins)
                {
                    if(user == a)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (User u in _users)
                {
                    if (user == u)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Prints an autorization error
        /// </summary>
        public void AutorizationError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\nRandom is very cruel sometimes, try again.\n");
            Console.WriteLine("Wrong input. There is no user matching given data");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// records who tried to sing in
        /// </summary>
        /// <param name="user"></param>
        public void RecordUser(User user)
        {
            _history.Add($"[{DateTime.Now}] [Username: {user.Username}] [User Type: {user.GetType().Name}]");
        }
        /// <summary>
        /// prints the autorization tries history
        /// </summary>
        public void PrintRecord()
        {
            Console.WriteLine("Who tried to sing in:");
            foreach (string record in _history)
            {
                Console.WriteLine(record);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// expexts data from a user
        /// </summary>
        /// <param name="user"></param>
        public void GetRequestFromUser(User user)
        {
            Console.WriteLine("Please, enter Username");
            user.Username = Console.ReadLine();
            Console.WriteLine("Please, enter Password");
            user.Password = Console.ReadLine();
        }

        public void GetRequestFromAdmin(Admin admin)
        {
            GetRequestFromUser(admin);
            Console.WriteLine("Please, enter Secret Key");
            admin.SecretKey = Console.ReadLine();
        }

        public void GerRequestFromEditor(Editor editor)
        {
            GetRequestFromUser(editor);
        }

        public void GetRequestFromGuest(Guest guest)
        {
            Console.WriteLine("Please, enter Username");
            guest.Username = Console.ReadLine();
        }
    }
}
