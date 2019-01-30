using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMSSendingApp1
{
    class Message
    {

        [Key]
        public int MessageId { get; set; }
        
        
        [ForeignKey("User")]
        public string Sender_Phone { get; set; }
        public User User { get; set; }

        [ForeignKey("Recipient")]
        public string Recipient_Phone { get; set; }
        public Recipient Recipient { get; set; }


        public DateTime Messaging_Time { get; set; }
        public string Text_Message { get; set; }
    }
}
