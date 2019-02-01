using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSSendingApp1
{
    public class ConsoleMessageSender : IMessageSender
    {
        public bool Send(Message message)
        {
            try
            {
                Console.WriteLine("Sender: {0}", message.Sender_Phone);
                Console.WriteLine("Reciever: {0}", message.Recipient_Phone);
                Console.WriteLine("Message: {0}", message.Text_Message);
                return true;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Message sending failed");
                return false;
            }
        }

        public bool Send(string message, string sender, string reciever)
        {
            try
            {
                Message MessageToSend = new Message { Sender_Phone = sender, Recipient_Phone = reciever,
                    Messaging_Time = DateTime.UtcNow, Text_Message = message };
                Console.WriteLine("Sender: {0}", MessageToSend.Sender_Phone);
                Console.WriteLine("Reciever: {0}", MessageToSend.Recipient_Phone);
                Console.WriteLine("Message: {0}", MessageToSend.Text_Message);
                return true;
            }
            catch
            {
                Console.WriteLine("Message sending failed");
                return false;
            }
        }

    }
}
