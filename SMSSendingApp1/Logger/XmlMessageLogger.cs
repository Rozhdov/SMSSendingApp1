using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMSSendingApp1
{
    namespace Logger
    {
        class XmlMessageLogger : IMessageLogger
        {


            public void Send(Message Message, string MessageLocation)
            {

                XElement MessagesLog;
                try
                {
                    MessagesLog = XElement.Load(MessageLocation);
                }
                catch (System.IO.FileNotFoundException e)
                {
                    MessagesLog = new XElement("Messages");
                }

                MessagesLog.Add(new XElement("Message",
                                    new XElement("Sender", Message.Sender_Phone),
                                    new XElement("Reciever", Message.Recipient_Phone),
                                    new XElement("Text", Message.Text_Message),
                                    new XAttribute("Date_and_time", Convert.ToString(Message.Messaging_Time))
                                ));
                MessagesLog.Save(MessageLocation);
            }

            public void Send(Message Message)
            {
                this.Send(Message, "XMLLog.xml");
            }




        }
    }
}
