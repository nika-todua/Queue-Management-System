using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba
{
    internal class QueueManager
    {

        private Queue<Client> queue;
        private int clientIdCounter;

        public QueueManager()
        {
            queue = new Queue<Client>();
            clientIdCounter = 1;
        }

        public void AddClient(string name)
        {
            var client = new Client(clientIdCounter++, name);
            queue.Enqueue(client);
            Console.WriteLine($"{client} added to the queue.");
        }

        public void CallNextClient()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No clients in the queue.");
                return;
            }

            var client = queue.Dequeue();
            Console.WriteLine($"{client} is being called to the operator.");
        }

        public void RemoveClient(int clientId)
        {
            var tempQueue = new Queue<Client>();
            bool clientFound = false;

            while (queue.Count > 0)
            {
                var client = queue.Dequeue();
                if (client.Id == clientId)
                {
                    clientFound = true;
                    Console.WriteLine($"{client} removed from the queue.");
                }
                else
                {
                    tempQueue.Enqueue(client);
                }
            }

            queue = tempQueue;

            if (!clientFound)
            {
                Console.WriteLine($"Client {clientId} not found in the queue.");
            }
        }

        public void DisplayQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
                return;
            }

            Console.WriteLine("Current queue:");
            foreach (var client in queue)
            {
                Console.WriteLine(client);
            }
        }

    }
}
