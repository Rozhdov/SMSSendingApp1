using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SMSContext db = new SMSContext())
            {
                User user1 = new User { UserId = "+380661851160", Password = "qwerty", Name = "Sasha", Address = "arlekin@arlekin.com" };
                db.Users.Add(user1);
                db.SaveChanges();
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
