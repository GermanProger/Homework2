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
        /// P.S. in real app, User parameter will be used.
        /// </summary>
        /// <param name="user">isn't used, but it must be here :)</param>
        /// <returns>true, if autorization is passed</returns>
        public bool IsAcceptable(User user)
        {
            Random r = new Random();
            return r.Next(1, 1000) > 800 ? true : false;
        }
        /// <summary>
        /// Prints an autorization error
        /// </summary>
        public void AutorizationError()
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("\nRandom is very cruel sometimes, try again.\n");
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
        public void PrintRecor()
        {
            Console.WriteLine("Who tried to sing in:");
            foreach (string record in _history)
            {
                Console.WriteLine(record);
            }
            Console.WriteLine();
        }
    }
}
