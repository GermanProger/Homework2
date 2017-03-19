using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //just for fun
            Console.ForegroundColor = ConsoleColor.White;
            int parsed;
            Admin admin = new Admin();
            Editor editor = new Editor();
            Guest guest = new Guest();
            List<User> users = new List<User>() { admin, editor, guest };
            while (true)
            {
                CommandLine.PrintUserTypes();
                int.TryParse(Console.ReadLine(), out parsed);
                if (parsed > 0 && parsed < 4)
                {
                    users[parsed - 1].Autorize();
                    Autorizator.Instance.RecordUser(users[parsed - 1]);
                    if (Autorizator.Instance.IsAcceptable(users[parsed - 1]))
                    {
                        CommandLine.RepeatInput();
                    }
                    else
                    {
                        Autorizator.Instance.AutorizationError();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //Autorizator.Instance.PrintRecor();
            }
        }
    }
}
