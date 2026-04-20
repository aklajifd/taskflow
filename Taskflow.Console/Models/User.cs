using System.Collections.Generic;

namespace Taskflow.Console.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; private set; }

        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        public abstract string GetSummary();

        public abstract List<string> GetPermissions();
    }
}