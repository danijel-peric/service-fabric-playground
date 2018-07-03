using System;
using System.Runtime.Serialization;

namespace AppShared
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public DateTime? Date { get; set; } 
    }
}
