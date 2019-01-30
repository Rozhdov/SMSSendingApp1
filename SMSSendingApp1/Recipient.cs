using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMSSendingApp1
{
    class Recipient
    {

        [Key]
        [MaxLength(50)]
        public string RecipientId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
