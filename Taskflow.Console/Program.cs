using Taskflow.Console.Models;
using Taskflow.Console.Interfaces;
using Taskflow.Console.Exceptions;

List<IDescribable> usersAndTasks = new List<IDescribable>();

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

TaskItem task1 = new TaskItem("Send emails", user1, "Low");
TaskItem task2 = new TaskItem("Clean office", user2, "Medium");
TaskItem task3 = new TaskItem("Gather supplies", user3, "High");

usersAndTasks.Add(user1);
usersAndTasks.Add(user2);
usersAndTasks.Add(user3);

usersAndTasks.Add(task1);
usersAndTasks.Add(task2);
usersAndTasks.Add(task3);

foreach (IDescribable item in usersAndTasks)
{
    Console.WriteLine(item.GetSummary());
}

List<ICompletable> tasks = new List<ICompletable>();

tasks.Add(task1);
tasks.Add(task2);
tasks.Add(task3);

CompleteAll(tasks);
Console.WriteLine("\nAfter completing all tasks:");
Console.WriteLine(task1.GetSummary());
Console.WriteLine(task2.GetSummary());
Console.WriteLine(task3.GetSummary());

Console.ReadLine();

static void CompleteAll(List<ICompletable> items)
{
    foreach(ICompletable taskItem in items)
    {
        taskItem.Complete();
    }
}