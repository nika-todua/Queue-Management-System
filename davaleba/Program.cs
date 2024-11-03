using System;
using davaleba;

namespace davaleba
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueManager = new QueueManager();

            while (true)
            {
                Console.WriteLine("\nQueue Management System");
                Console.WriteLine("1. Add client to queue");
                Console.WriteLine("2. Call next client");
                Console.WriteLine("3. Remove client from queue");
                Console.WriteLine("4. Display queue");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter client name: ");
                        string name = Console.ReadLine();
                        queueManager.AddClient(name);
                        break;
                    case "2":
                        queueManager.CallNextClient();
                        break;
                    case "3":
                        Console.Write("Enter client ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int clientId))
                        {
                            queueManager.RemoveClient(clientId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID. Please enter a number.");
                        }
                        break;
                    case "4":
                        queueManager.DisplayQueue();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
