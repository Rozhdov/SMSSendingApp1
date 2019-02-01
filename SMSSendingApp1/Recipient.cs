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
    public class Recipient
    {

        [DataMember]
        [StringLength(13, ErrorMessage = "Lenght of phone number should be less than 13")]
        public string RecipientId { get; set; }
        
        [DataMember]
        [StringLength(50, ErrorMessage = "Username can't be longer than 50 symbols")]
        public string Name { get; set; }

        [DataMember]
        [StringLength(254, ErrorMessage = "Standart specifies lenght of email no more than 254 symbols")]
        public string Address { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
