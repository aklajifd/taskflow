using Taskflow.Console.Interfaces;
using Taskflow.Console.Exceptions;
using Taskflow.Console.Repositories;

namespace Taskflow.Console.Models
{
	public class TaskItem : IDescribable, ICompletable, IEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsComplete { get; private set; }
		public User AssignedTo { get; set; }
		public string Priority { get; set; }

		public TaskItem(string title, User assignedTo, string priority = "Medium")
		{
			if (string.IsNullOrWhiteSpace(title))
			{
				throw new ArgumentException($"Invalid input - Title must have a value");
			}
			Title = title;

			if (assignedTo is null)
			{
				throw new ArgumentNullException("Invalid input - Assigned To must have a value");
			}
			AssignedTo = assignedTo;

			Description = string.Empty;
			IsComplete = false;
			SetPriority(priority);
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

		public void SetPriority(string priority)
		{
			if (priority != "Low" && priority != "Medium" && priority != "High")
			{
				throw new InvalidPriorityException(priority);
			}
			Priority = priority;
		}
	}
}