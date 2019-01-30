using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SMSSendingApp1
{
    class SMSContext : DbContext
    {
        public SMSContext() : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
    }
}
