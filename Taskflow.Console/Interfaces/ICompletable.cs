namespace Taskflow.Console.Interfaces
{
    public interface ICompletable
    {
        bool IsComplete { get; }
        void Complete();
    }
}