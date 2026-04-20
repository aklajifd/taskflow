using System.Collections.Generic;

namespace Taskflow.Console.Models
{
    public class Admin : User
    {
        public Admin(string fullName, string email) : base(fullName, email) { }

        public override string GetSummary()
        {
            return $"[Admin] {FullName}";
        }

        public override List<string> GetPermissions()
        {
            List<string> permissions = ["ViewTasks", "CompleteTasks", "CreateTasks", "DeleteTasks", "ManageUsers"];
            return permissions;
        }
    }
}