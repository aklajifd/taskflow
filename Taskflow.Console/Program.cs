using Taskflow.Console.Models;

List<User> users = new List<User>();
Admin user1 = new Admin("Harry Potter", "hpotter@gmail.com");
Member user2 = new Member("Ron Weasley", "rweasley@gmail.com");
Member user3 = new Member("Hermione Granger", "hgranger@gmail.com");

users.Add(user1);
users.Add(user2);
users.Add(user3);

List<TaskItem> tasks = new List<TaskItem>();
TaskItem task1 = new TaskItem("Send emails", user1, "Low");
TaskItem task2 = new TaskItem("Clean office", user2, "Medium");
TaskItem task3 = new TaskItem("Gather supplies", user3, "High");

tasks.Add(task1);
tasks.Add(task2);
tasks.Add(task3);

foreach (User user in users)
{
    Console.WriteLine(user.GetSummary());
    Console.WriteLine(string.Join(", ", user.GetPermissions()));
}

foreach(TaskItem task in tasks)
{
    Console.WriteLine(task.GetSummary());
}

task1.Complete();
Console.WriteLine("\nAfter completing TaskItem1:");
Console.WriteLine(task1.GetSummary());
Console.ReadLine();