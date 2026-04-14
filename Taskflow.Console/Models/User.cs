namespace Taskflow.Console.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; private set; }
        public string Role { get; set; }

        public User(string fullName, string email, string role)
        {
            FullName = fullName;
            Email = email;
            Role = role;
        }

        public string GetSummary()
        {
            return $"[{Role}] {FullName} - {Email}";
        }
    }
}