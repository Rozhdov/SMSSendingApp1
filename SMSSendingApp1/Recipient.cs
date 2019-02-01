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
        private string recipientId;
        [StringLength(13)]
        public string RecipientId
        {
            get
            {
                return this.recipientId;
            }
            set
            {
                Regex Expression = new Regex(@"^[0-9\+\*\#]{3,13}$");
                if (Expression.IsMatch(value))
                    recipientId = value;
                else
                    throw new ArgumentException("Incorrect value for userId");
            }
        }

        [DataMember]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Address { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
