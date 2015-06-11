using System.Runtime.Serialization;

namespace WCFServiceWithAzureServiceBusQueue
{
    [DataContract(Name = "MessageDataContract", Namespace = "Robert.Broomandan")]
    public class Message
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}