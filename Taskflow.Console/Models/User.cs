using Taskflow.Console.Interfaces;
using Taskflow.Console.Exceptions;

namespace Taskflow.Console.Models
{
    public abstract class User : IDescribable, IPermissioned
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; private set; }

        public User(string fullName, string email)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException($"Invalid input - User name must have a value");
            }
            FullName = fullName;

            if (email.Contains('@') && email.Contains('.'))
            {
                Email = email;
            }
            else
            {
                throw new InvalidEmailException(email);
            }
        }

        public abstract string GetSummary();

        public abstract List<string> GetPermissions();
    }
}