namespace SMSSendingApp1
{
    namespace Sender
    {

        interface IMessageSender
        {
            bool Send(string message, string sender, string reciever);
            bool Send(Message message);
        }
    }
}
