using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    // class for validation of input data
    static class InputValidation
    {
        static public bool PhoneNumberIsValid(string Phone)
        {
            Regex Expression = new Regex(@"^[0-9\+\*\#]{3,13}$");
            return Expression.IsMatch(Phone)? true : false;
        }

        static public bool PasswordIsValid(string Phone)
        {
            return true;
        }

        static public bool NameIsValid(string Phone)
        {
            return true;
        }

        static public bool AddressIsValid(string Phone)
        {
            return true;
        }

    }
}
