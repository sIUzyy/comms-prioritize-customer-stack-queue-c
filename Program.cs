using System;
using System.Collections.Generic;

namespace StackAndQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack and a queue to hold customer information
            var stack = new Stack<(string Name, int Age)>();
            var queue = new Queue<(string Name, int Age)>();

            // Input customer information
            Console.WriteLine("Enter customer information (Name and Age): \n");
            while (true)
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();

                // Check if the user wants to stop inputting data
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }

                Console.Write("Age: ");
                var age = int.Parse(Console.ReadLine());

                // If the customer is a senior citizen, add them to the stack
                // Otherwise, add them to the queue
                if (age >= 60)
                {
                    stack.Push((Name: name, Age: age));
                }
                else
                {
                    queue.Enqueue((Name: name, Age: age));
                }
            }

            // Print the list of customers, starting with senior citizens
            Console.WriteLine("List of customers:");
            while (stack.Count > 0)
            {
                var customer = stack.Pop();
                Console.WriteLine($"{customer.Name} ({customer.Age})");
            }

            while (queue.Count > 0)
            {
                var customer = queue.Dequeue();
                Console.WriteLine($"{customer.Name} ({customer.Age})");
            }
        }
    }
}
