using System;

namespace SmsMail_SendHair
{
    public class SendHair_App
    {
        private readonly ISender _sender;
        public SendHair_App(ISender sender)
        {
            _sender = sender;
        }
        
        public string Send(string message)
            => _sender.Send(message);
    }
}