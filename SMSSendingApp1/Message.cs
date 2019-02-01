using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SMSSendingApp1
{
    [Serializable]
    [DataContract]
    public class Message
    {
        [DataMember]
        [Key]
        public int MessageId { get; set; }
        
        [DataMember]
        [ForeignKey("User")]
        public string Sender_Phone { get; set; }
        public virtual User User { get; set; }

        [DataMember]
        [ForeignKey("Recipient")]
        public string Recipient_Phone { get; set; }
        public virtual Recipient Recipient { get; set; }

        [DataMember]
        public DateTime Messaging_Time { get; set; }

        [DataMember]
        public string Text_Message { get; set; }
    }
}
