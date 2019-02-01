using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SMSSendingApp1.Logger
{
    class JsonMessageLogger : IMessageLogger
    {
        public void Send(Message Message, string SaveLocation)
        {
            DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(Message));
            using (FileStream fs = new FileStream(SaveLocation, FileMode.Append))
            {
                JsonSerializer.WriteObject(fs, Message);
            }
        }

        public void Send(Message Message)
        {
            this.Send(Message, "JSONLog.json");
        }
    }
}
