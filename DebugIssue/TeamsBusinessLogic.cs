using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DebugIssue
{
    public class TeamsBusinessLogic
    {
        public void RemoveTeamsFromWorkflowActivities(IReadOnlyCollection<Guid> deletedTeams, List<AssigneeGroup> assigneeGroups)
        {
            var isAnyRemoved = removeTeamsFromConfiguration(deletedTeams, assigneeGroups);
        }

        private bool removeTeamsFromConfiguration(IEnumerable<Guid> deletedTeams, IEnumerable<AssigneeGroup> assigneeGroups)
        {
            var isAnyRemoved = false;
            var deletedTeamsList = deletedTeams.ToList();
            foreach (var assigneeGroup in assigneeGroups)
            {
                // Find the intersection of the list of deleted teams and users in the specified assignee group.
                var foundTeamsIdToDelete = assigneeGroup.AssignedTeamIds.Select(at => at.Id).Intersect(deletedTeamsList).ToList();

                if (!foundTeamsIdToDelete.Any())
                {
                    continue;
                }
                isAnyRemoved = true;
                foreach (var teamId in foundTeamsIdToDelete)
                {
                    var team = assigneeGroup.AssignedTeamIds.FirstOrDefault(x => x.Id.Equals(teamId));
                    if (team == null)
                    {
                        continue;
                    }

                    assigneeGroup.AssignedTeamIds.Remove(team);

                }
            }

            return isAnyRemoved;
        }
    }
}