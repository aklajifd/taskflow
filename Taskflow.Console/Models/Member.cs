namespace Taskflow.Console.Models
{
    public class Member : User
    {
        public Member(string fullName, string email) : base(fullName, email) {}

        public override string GetSummary()
        {
            return $"[Member] {FullName}";
        }

        public override List<string> GetPermissions()
        {
            List<string> permissions = ["ViewTasks", "CompleteTasks"];
            return permissions;
        }
    }
}