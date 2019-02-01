using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    namespace ConsoleUI
    {
        // Validation of input data from console. Most of method use regex,
        // email valiation call cosnstructor for MailAddress, which throw exceptions if invalid
        
        static class ConsoleInputValidation
        {
            static public bool PhoneNumberIsValid(string Phone)
            {
                Regex Expression = new Regex(@"^[0-9\+\*\#]{3,13}$");
                return Expression.IsMatch(Phone);                
            }

            static public bool PasswordIsValid(string Password)
            {
                Regex Expression = new Regex(@"^[\w!@#$%^&*]{3,50}$");
                return Expression.IsMatch(Password);
            }

            static public bool NameIsValid(string Name)
            {
                Regex Expression = new Regex(@"^\w{3,50}$");
                return Expression.IsMatch(Name); ;
            }

            static public bool AddressIsValid(string Email)
            {
                try
                {
                    new System.Net.Mail.MailAddress(Email);
                }
                catch
                {
                    return false;
                }
                return true;
            }

        }
    }
}
