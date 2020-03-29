using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DataContract
{
    [System.SerializableAttribute()]
    public class AssigneeGroup
    {
        public AssigneeGroup()
        {
            this.initialize();
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            this.initialize();
        }
        private void initialize()
        {
            this.AssignedUsers = new List<User>();
            this.AssignedTeamIds = new List<Identifier>();
            this.AssigneeGroupName = "<default>";
        }

        [DataMember]
        public List<User> AssignedUsers { get; set; }

        [DataMember]
        public List<Identifier> AssignedTeamIds { get; set; }

        [DataMember]
        public string AssigneeGroupName { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }
    }
}