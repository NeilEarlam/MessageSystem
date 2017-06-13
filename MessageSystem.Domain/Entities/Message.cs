using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem.Domain.Entities
{
    public enum MessageType
    {
        SMS,
        Twitter
    }

    public abstract class MessageBase
    {
        public string Id { get; set; }
        public string Sender { get; set; }
        public string Body { get; set; }
        public int MaxSize { get; set; }
        public MessageType Type { get; set; }
    }

    public class SmsMessage : MessageBase
    {
        public SmsMessage()
        {
            Id = string.Empty;
            Sender = string.Empty;
            Body = string.Empty;
            MaxSize = 140;
            Type = MessageType.SMS;
        }
    }

    public class TwitterMessage : MessageBase
    {
        public TwitterMessage()
        {
            Id = string.Empty;
            Sender = string.Empty;
            Body = string.Empty;
            MaxSize = 140;
            Type = MessageType.Twitter;
        }
    }
}
