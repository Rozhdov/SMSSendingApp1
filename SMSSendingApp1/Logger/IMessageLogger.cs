using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    namespace Logger
    {
        interface IMessageLogger
        {
            void Send(Message Message, string SaveLocation);
            void Send(Message Message);
        }
    }

}