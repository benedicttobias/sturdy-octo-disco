using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DataContract
{
    public class User
    {
        [DataMember]
        public string SID { get; set; }

        private string displayName { get; set; }

        [DataMember]
        public string DisplayName
        {
            get
            {
                if (string.IsNullOrEmpty(displayName))
                {
                    return ((FirstName ?? string.Empty) + ' ' + (LastName ?? string.Empty)).Trim();
                }
                else
                {
                    return displayName;
                }

            }
            set
            {
                displayName = value;
            }
        }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public UserStatusType Status { get; set; }

        [DataMember]
        public bool HasVersionsPermission { get; private set; }

        [DataMember]
        public bool HasSuperAdministratorRole { get; private set; }

        [DataMember]
        public bool HasSystemAdministratorRole { get; private set; }

        [DataMember]
        public bool HasIntegrationAdministratorRole { get; private set; }

        [DataMember]
        public bool HasUserAndTeamAdministratorRole { get; private set; }

        [DataMember]
        public bool HasPermissionAdministratorRole { get; private set; }

        [DataMember]
        public bool HasMatchingAndSurvivorshipAdministratorRole { get; private set; }

        [DataMember]
        public bool HasMatchingAndSurvivorshipUserRole { get; private set; }

        [DataMember]
        public bool HasAddressVerificationAdministratorRole { get; private set; }

        [DataMember]
        public bool HasAddressVerificationUserRole { get; private set; }

        [DataMember]
        public bool HasDataArchiveAdministratorRole { get; private set; }

        [DataMember]
        public bool HasReportAdministratorRole { get; private set; }

        [DataMember]
        public bool HasRulesAdministratorRole { get; private set; }

        [DataMember]
        public bool HasEventAdministratorRole { get; private set; }

        [DataMember]
        public bool HasPortalAdministratorRole { get; private set; }

        [DataMember]
        public bool HasWorkflowAdministratorRole { get; private set; }

        [DataMember]
        public bool HasBulkUpdateUserRole { get; private set; }

        //[DataMember]
        //public List<UserTeam> Teams { get; set; }

        //[DataMember]
        //public List<UserRole> Roles { get; set; }

        //[DataMember]
        //public List<Permission> Permissions { get; set; }

        //[DataMember]
        //public List<SecurityFilter> SecurityFilters { get; set; }

        //[DataMember]
        //public List<Permission> EffectivePermissions { get; set; }

        //[DataMember]
        //public List<UserRole> EffectiveRoles { get; set; }

        //[DataMember]
        //public List<SecurityFilter> EffectiveSecurityFilters { get; set; }

        //[DataMember]
        //public UserType Type { get; set; }

        //[DataMember]
        //public List<UserGroupMembership> UserGroupMemberships { get; set; }

        [DataMember]
        public int RoleDisplayCount { get; set; }

        [DataMember]
        public int TeamDisplayCount { get; set; }
    }
}