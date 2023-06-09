﻿using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Synchronous execution:");
        SynchronousExample();

        Console.WriteLine("\nAsynchronous execution:");
        AsynchronousExample().Wait(); // Wait for the asynchronous example to complete
    }

    static void SynchronousExample()
    {
        DoWork("Task 1");
        DoWork("Task 2");
    }

    static async Task AsynchronousExample()
    {
        Task task1 = DoWorkAsync("Task 1");
        Task task2 = DoWorkAsync("Task 2");

        await Task.WhenAll(task1, task2);
    }

    static void DoWork(string taskName)
    {
        Console.WriteLine($"{taskName} started");
        Thread.Sleep(2000); // Simulate work by waiting for 2 seconds
        Console.WriteLine($"{taskName} completed");
    }

    static async Task DoWorkAsync(string taskName)
    {
        Console.WriteLine($"{taskName} started");
        await Task.Delay(2000); // Simulate work by waiting for 2 seconds asynchronously
        Console.WriteLine($"{taskName} completed");
    }
}
