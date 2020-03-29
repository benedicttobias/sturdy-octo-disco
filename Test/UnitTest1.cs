using System;
using System.Collections.Generic;
using DataContract;
using DebugIssue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private TeamsBusinessLogic _sut;

        [TestMethod]
        public void TestMethod1()
        {
            _sut = new TeamsBusinessLogic();

            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            var guid3 = Guid.NewGuid();

            var assigneeGroups = new List<AssigneeGroup>()
            {
                new AssigneeGroup()
                {
                    AssignedTeamIds = new List<Identifier>()
                    {
                        new Identifier {Id = guid1},
                        new Identifier {Id = guid2},
                        new Identifier {Id = guid3}
                    }
                }
            };

            var deletedTeams = new List<Guid>
            {
                guid2
            };

            _sut.RemoveTeamsFromWorkflowActivities(deletedTeams, assigneeGroups);
        }
    }
}
