namespace Taskflow.Console.Models
{
	public class TaskItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsComplete { get; private set; }
		public User AssignedTo { get; set; }

		public TaskItem(string title, User assignedTo)
		{
			Title = title;
			AssignedTo = assignedTo;
			Description = string.Empty;
			IsComplete = false;
		}

		public void Complete()
		{
			IsComplete = true;
		}

		public string GetSummary()
		{
			string status = IsComplete ? "COMPLETE" : "INCOMPLETE";
			return $"[{status}] {Title} - Assigned to: {AssignedTo.FullName}";
		}
	}
}