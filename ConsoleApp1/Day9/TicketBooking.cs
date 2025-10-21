using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day9
{
    internal class TicketBooking
    {
        public TicketBooking() { 
            Queue<String> ticketQueue = new Queue<String>();
            ticketQueue.Enqueue("Alice");
            ticketQueue.Enqueue("Bob");
            ticketQueue.Enqueue("Charlie");
            ticketQueue.Enqueue("Diana");
            ticketQueue.Enqueue("Ethan");

            Console.WriteLine("=== Ticket Booking System ===");

            if (ticketQueue.Count > 0) { 
                String servedCustomer= ticketQueue.Dequeue();
                Console.WriteLine($"The served Customer : {servedCustomer}");
            }
            Console.WriteLine("\nRemaining customers in queue:");
            if (ticketQueue.Count > 0)
            {
                foreach (var customer in ticketQueue)
                {
                    Console.WriteLine(customer);
                }
            }
            else
            {
                Console.WriteLine("No more customers in the queue.");
            }

        }
    }
}
