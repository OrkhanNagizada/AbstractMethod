using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractionHomeTask
{
    public class User
    {
        public static int userCount = 0;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string password;


        public User(string fullname, string email, string password)
        {
            this.Id = ++userCount;
            this.Fullname = fullname;
            this.Email = email;

            if (PasswordChecker(password))
            {
                this.password = password;
            }
            else
            {
                throw new ArgumentException("Passwordu duz yaz");
            }
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;                                //ChatGBT isdifade etmishem(Ama regexi bilirem)
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            return true;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Email: {Email}");
        }

        public static void FindUserById(int id, User[] users)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    user.GetInfo();
                    return;
                }
            }
            Console.WriteLine("Bele User yoxdu.");
        }
    }
}
