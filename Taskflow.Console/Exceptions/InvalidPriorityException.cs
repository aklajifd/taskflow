namespace Taskflow.Console.Exceptions
{
    public class InvalidPriorityException : Exception
    {
        public InvalidPriorityException(string priority)
            : base($"'{priority}' is not a valid priority. Use Low, Medium, or High.")
        {

        }
    }
}