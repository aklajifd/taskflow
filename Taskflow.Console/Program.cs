using Taskflow.Console.Models;
using Taskflow.Console.Interfaces;
using Taskflow.Console.Exceptions;
using Taskflow.Console.Repositories;

Repository<User> users = new Repository<User>();
Repository<TaskItem> tasks = new Repository<TaskItem>();

try
{
    new Admin("", "hpotter@gmail.com");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.Message}");
}
catch (InvalidEmailException ex)
{
    Console.WriteLine($"{ex.Message}");
}

try
{
    new Member("Ron Weasley", "not-an-email");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.Message}");
}
catch (InvalidEmailException ex)
{
    Console.WriteLine($"{ex.Message}");
}

Admin user1 = new Admin("Harry Potter", "hpotter@gmail.com");
Member user2 = new Member("Ron Weasley", "rweasley@gmail.com");
Member user3 = new Member("Hermione Granger", "hgranger@gmail.com");

users.Add(user1);
users.Add(user2);
users.Add(user3);

TaskItem task1 = new TaskItem("Send emails", user1, "Low");
TaskItem task2 = new TaskItem("Clean office", user2, "Medium");
TaskItem task3 = new TaskItem("Gather supplies", user3, "High");

tasks.Add(task1);
tasks.Add(task2);
tasks.Add(task3);

User? fetchedUser = users.GetById(2);
if (fetchedUser is not null)
{
    Console.WriteLine(fetchedUser.GetSummary());
}

TaskItem? fetchedTask = tasks.GetById(2);
if (fetchedTask is not null)
{
    Console.WriteLine(fetchedTask.GetSummary());
}

fetchedTask.Complete();
Console.WriteLine("\nAfter completing fetched task:");
Console.WriteLine(fetchedTask.GetSummary());

Console.WriteLine("\nDeleting task...");
tasks.Delete(1);
Console.WriteLine("Current tasks:");

foreach(TaskItem task in tasks.GetAll())
{
    Console.WriteLine(task.GetSummary());
}

Console.ReadLine();

static void CompleteAll(List<ICompletable> items)
{
    foreach(ICompletable taskItem in items)
    {
        taskItem.Complete();
    }
}