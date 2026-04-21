using Taskflow.Console.Interfaces;

namespace Taskflow.Console.Models
{
	public class TaskItem : IDescribable, ICompletable
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsComplete { get; private set; }
		public User AssignedTo { get; set; }
		public string Priority { get; set; }

		public TaskItem(string title, User assignedTo, string priority = "Medium")
		{
			Title = title;
			AssignedTo = assignedTo;
			Description = string.Empty;
			IsComplete = false;
			Priority = priority;
		}

		public void Complete()
		{
			IsComplete = true;
		}

		public string GetSummary()
		{
			string status = IsComplete ? "COMPLETE" : "INCOMPLETE";
			return $"[{status}][{Priority}] {Title} - Assigned to: {AssignedTo.FullName}";
		}
	}
}