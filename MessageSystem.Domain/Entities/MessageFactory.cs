using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem.Domain.Entities
{
    public static class MessageFactory
    {
        public static MessageBase Factory(MessageType type)
        {
            switch(type)
            {
                case MessageType.SMS:
                    return new SmsMessage();
                case MessageType.Twitter:
                    return new TwitterMessage();
                default:
                    return null;
            }
        }
    }
}
