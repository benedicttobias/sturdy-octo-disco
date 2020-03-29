using System;
using System.Runtime.Serialization;

namespace DataContract
{
    public class Identifier
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public int InternalId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsReferenceValid { get; set; }
    }
}