using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    interface IMessageSender
    {
        bool Send(string message, string sender, string reciever);
        bool Send(Message message);
    }
}
