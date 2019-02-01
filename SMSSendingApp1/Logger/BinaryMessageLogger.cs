using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SMSSendingApp1
{
    namespace Logger
    {
        class BinaryMessageLogger : IMessageLogger
        {
            public void Send(Message Message, string SaveLocation)
            {
                BinaryFormatter Logger = new BinaryFormatter();
                using (FileStream fs = new FileStream(SaveLocation, FileMode.Append))
                {
                    Logger.Serialize(fs, Message);
                }
            }

            public void Send(Message Message)
            {
                this.Send(Message, "BinaryLog.dat");
            }
        }
    }
}
