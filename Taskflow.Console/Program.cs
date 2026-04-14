using Taskflow.Console.Models;

User user1 = new User("Harry Potter", "hpotter@gmail.com", "Member");
User user2 = new User("Ron Weasley", "rweasley@gmail.com", "Member");

TaskItem task1 = new TaskItem("Send emails", user1);
TaskItem task2 = new TaskItem("Clean office", user2);
TaskItem task3 = new TaskItem("Gather supplies", user1);

Console.WriteLine(task1.GetSummary());
Console.WriteLine(task2.GetSummary());
Console.WriteLine(task3.GetSummary());

task1.Complete();
Console.WriteLine("\nAfter completing TaskItem1:");
Console.WriteLine(task1.GetSummary());
Console.ReadLine();