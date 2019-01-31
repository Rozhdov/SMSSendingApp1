using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SMSSendingApp1
{
    static partial class ConsoleUserInterface
    {
        public static void StartInteface()
        {
            while (true)
            {
                WriteLine("SMS sender application");
                WriteLine("Select from the following:");
                WriteLine("1 - Authorization");
                WriteLine("2 - Registration");
                WriteLine("q - Exit application");
                string consoleInput = ReadLine();
                consoleInput.Trim();
                
                switch (consoleInput)
                {
                    case "1":
                        Authorization();
                        break;
                    case "2":
                        Registration();
                        break;
                    case "q":
                        return;
                    default:
                        WriteLine("Incorrect option");
                        break;
                }
            }
        }

        public static void Authorization()
        {
            using (SMSContext db = new SMSContext())
            {
                while (true)
                {
                    WriteLine("Input your phone number:");
                    string phoneInput = ReadLine();
                    WriteLine("Input you password:");
                    string passwordInput = ReadLine();
                    var AuthorizedUser = db.Users.Find(phoneInput);
                    if ((AuthorizedUser == null) || AuthorizedUser.Password != passwordInput)
                    {
                        WriteLine("Incorrect phone number or password");
                        return;
                    }
                    else
                    {
                        AuthorizedInteface(AuthorizedUser);
                        //before authorized interface implementation
                        return;
                    }
                }
            }
        }

        public static void Registration()
        {
            User UnregisteredUser = new User();
            UnregisteredUser = registerPhoneNuber(UnregisteredUser);
            if (UnregisteredUser == null)
                return;
            UnregisteredUser = registerPassword(UnregisteredUser);
            if (UnregisteredUser == null)
                return;
            UnregisteredUser = registerName(UnregisteredUser);
            if (UnregisteredUser == null)
                return;
            UnregisteredUser = registerAddress(UnregisteredUser);
            if (UnregisteredUser == null)
                return;
            using (SMSContext db = new SMSContext())
            {
                db.Users.Add(UnregisteredUser);
                var tempRecipient = (from r in db.Recipients
                                where r.RecipientId == UnregisteredUser.UserId
                                select r).FirstOrDefault<Recipient>();
                if (tempRecipient == null)
                {
                    var newRecipient = new Recipient()
                    {
                        RecipientId = UnregisteredUser.UserId,
                        Name = UnregisteredUser.Name,
                        Address = UnregisteredUser.Address
                    };
                    db.Recipients.Add(newRecipient);
                }
                else
                {
                    tempRecipient.Name = UnregisteredUser.Name;
                    tempRecipient.Address = UnregisteredUser.Address;
                }
                db.SaveChanges();
            }
            AuthorizedInteface(UnregisteredUser);


        }

        private static User registerPhoneNuber(User unregisteredUser)
        {
            using (SMSContext db = new SMSContext())
            {
                while (true)
                {
                    WriteLine("Please, enter phone number:");
                    string consoleInput = ReadLine();
                    consoleInput = consoleInput.Replace(" ", "").Replace("(", "").Replace(")", "");

                    if (PhoneNumberIsValid(consoleInput))
                    {
                        var tempUser = (from u in db.Users
                                        where u.UserId == consoleInput
                                        select u).FirstOrDefault();
                        if (tempUser != null)
                        {
                            WriteLine("User with this phone nuber already exist");
                            WriteLine("Try again? Y/n");
                            consoleInput = ReadLine();
                            switch (consoleInput)
                            {
                                case "y":
                                case "Y":
                                    continue;
                                case "n":
                                case "N":
                                    return null;
                                default:
                                    continue;
                            }
                                
                        }
                        else
                        {
                            unregisteredUser.UserId = consoleInput;
                            return unregisteredUser;
                        }
                    }
                    else
                    {
                        WriteLine("Incorrect phone number");
                        WriteLine("Try again? Y/n");
                        consoleInput = ReadLine();
                        switch (consoleInput)
                        {
                            case "y":
                            case "Y":
                                continue;
                            case "n":
                            case "N":
                                return null;
                            default:
                                continue;
                        }
                    }
                }
            }
        }

        private static User registerPassword(User unregisteredUser)
        {
            while (true)
            {
                WriteLine("Please, enter password:");
                string consoleInput = ReadLine();
                if (PasswordIsValid(consoleInput))
                {
                    unregisteredUser.Password = consoleInput;
                    return unregisteredUser;
                }
                else
                {
                    WriteLine("Incorrect password");
                    WriteLine("Try again? Y/n");
                    consoleInput = ReadLine();
                    switch (consoleInput)
                    {
                        case "y":
                        case "Y":
                            continue;
                        case "n":
                        case "N":
                            return null;
                        default:
                            continue;
                    }
                }
            }


        }

        private static User registerName(User unregisteredUser)
        {
            while (true)
            {
                WriteLine("Please, enter username:");
                string consoleInput = ReadLine();
                if (NameIsValid(consoleInput))
                {
                    unregisteredUser.Name = consoleInput;
                    return unregisteredUser;
                }
                else
                {
                    WriteLine("Incorrect username");
                    WriteLine("Try again? Y/n");
                    consoleInput = ReadLine();
                    switch (consoleInput)
                    {
                        case "y":
                        case "Y":
                            continue;
                        case "n":
                        case "N":
                            return null;
                        default:
                            continue;
                    }
                }
            }
        }

        private static User registerAddress(User unregisteredUser)
        {
            while (true)
            {
                WriteLine("Please, enter email:");
                string consoleInput = ReadLine();
                if (AddressIsValid(consoleInput))
                {
                    unregisteredUser.Address = consoleInput;
                    return unregisteredUser;
                }
                else
                {
                    WriteLine("Incorrect email");
                    WriteLine("Try again? Y/n");
                    consoleInput = ReadLine();
                    switch (consoleInput)
                    {
                        case "y":
                        case "Y":
                            continue;
                        case "n":
                        case "N":
                            return null;
                        default:
                            continue;
                    }
                }
            }
        }

        private static void AuthorizedInteface(User AuthorizedUser)
        {
            WriteLine("Grac");
        }
    }
}
