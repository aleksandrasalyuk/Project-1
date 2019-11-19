using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupValidation
{
    public class Group
    {
        public string GroupName { get; private set; }
        public string GroupID { get; private set; }

        private static List<string> GroupIDs = new List<string>();

        private static List<Group> GroupsList = new List<Group>();

        public static Group CreateGroup(string groupName, string groupId, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(groupName) || groupName.Length > 100)
            {
                error = "Group name should be between 1-100 characters";
                return null;
            }
            if (string.IsNullOrWhiteSpace(groupId) || groupId.Length > 100)
            {
                error = "Group ID should be between 1-100 characters";
                return null;
            }
            if (GroupIDs.Contains(groupId))
            {
                error = "Group ID already exists";
                return null;
            }
            Group createdGroup = CreateGroupInDB(groupName, groupId);
            return createdGroup;
        }

        private static Group CreateGroupInDB(string groupName, string groupId)
        {
            Group newGroup = new Group();
            newGroup.GroupName = groupName;
            newGroup.GroupID = groupId;
            GroupsList.Add(newGroup);
            return newGroup;
        }
    }
}
