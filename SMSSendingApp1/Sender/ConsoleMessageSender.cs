using System;

namespace SMSSendingApp1
{
    namespace Sender
    {
        public class ConsoleMessageSender : IMessageSender
        {
            public bool Send(Message message)
            {
                    Console.WriteLine("Sender: {0}", message.Sender_Phone);
                    Console.WriteLine("Reciever: {0}", message.Recipient_Phone);
                    Console.WriteLine("Message: {0}", message.Text_Message);
                    return true;                
            }

            public bool Send(string message, string sender, string reciever)
            {                
                Message MessageToSend = new Message
                {
                    Sender_Phone = sender,
                    Recipient_Phone = reciever,
                    Messaging_Time = DateTime.UtcNow,
                    Text_Message = message
                };
                Console.WriteLine("Sender: {0}", MessageToSend.Sender_Phone);
                Console.WriteLine("Reciever: {0}", MessageToSend.Recipient_Phone);
                Console.WriteLine("Message: {0}", MessageToSend.Text_Message);
                return true;               
            }

        }
    }
}
