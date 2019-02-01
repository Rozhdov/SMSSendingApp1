using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace SMSSendingApp1
{
    [Serializable]
    [DataContract]
    public class User
    {
        [DataMember]
        [StringLength(13, ErrorMessage = "Lenght of phone number should be less than 13")]
        public string UserId { get; set; }

        [DataMember]
        [StringLength(50, ErrorMessage = "Password can't be longer than 50 symbols"), Required]
        public string Password { get; set; }

        [DataMember]
        [StringLength(50, ErrorMessage = "Username can't be longer than 50 symbols"), Required]
        public string Name { get; set; }

        [DataMember]
        [StringLength(254, ErrorMessage = "Standart specifies lenght of email no more than 254 symbols"), Required]
        public string Address { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }


}
