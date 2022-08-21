using System;
using System.Collections.Generic;

namespace GenericQueue
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(9);
            queue.Enqueue(8);
            queue.Enqueue(7);
            //adding duplicate
            queue.Enqueue(9);

            //removing queue
            queue.Dequeue();

            Console.WriteLine("Generic Queue Elements are as follows:");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}