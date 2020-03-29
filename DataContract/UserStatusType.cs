using System.Runtime.Serialization;

namespace DataContract
{
    public enum UserStatusType
    {
        [EnumMember]
        Active = 0,
        [EnumMember]
        Inactive = 1,
    }
}