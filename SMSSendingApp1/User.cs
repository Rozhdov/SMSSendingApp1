using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace SMSSendingApp1
{
    class User
    {

        [MaxLength(13)]
        private string userId;
        public string UserId {
            get
            {
                return this.userId;
            }
            set
            {
                Regex Expression = new Regex(@"^[0-9\+\*\#]{3,13}$");
                
                if (Expression.IsMatch(value))
                    userId = value;
                else
                    throw new ArgumentException("Incorrect value for userId");
            }
        }

        [MaxLength(50), Required]
        public string Password { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }

        [MaxLength(50), Required]
        public string Address { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }


}
