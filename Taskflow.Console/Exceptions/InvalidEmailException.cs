namespace Taskflow.Console.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email) : base($"{email} is invalid - Must include characters @ and .")
        {

        }
    }
}