// using System;
// using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new();
            Console.WriteLine("Welcome to the Task Management System");

            while (true)
            {
                Console.WriteLine("1. Add Tasks");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. Update Task Status");
                Console.WriteLine("4. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        var description = Console.ReadLine();

                        var newTask = new TaskManagementSystem.Models.Task { Name = name, Description = description, Deadline = DateTime.Now.AddDays(7), Priority = 2 };
                        taskManager.AddTask(newTask);
                        Console.WriteLine("Task added successfully!");
                        break;

                    case "2":
                        var tasks = taskManager.GetAllTasks();
                        foreach (var task in tasks)
                        {
                            Console.WriteLine($"{task.Id}: {task.Name} - {task.Status}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter task ID: ");
                        var id = int.Parse(Console.ReadLine());
                        Console.Write("Enter new status: ");
                        var status = Console.ReadLine();
                        taskManager.UpdateTaskStatus(id, status);
                        Console.WriteLine("Task status updated!");
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
