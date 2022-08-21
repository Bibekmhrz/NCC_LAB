using System;
using System.Collections.Generic;

namespace GenericStack
{
    public class Program
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(9);
            stack.Push(8);
            stack.Push(7);
            //adding duplicate
            stack.Push(8);

            //removing element
            stack.Pop();

            Console.WriteLine("Generic Stack Elements are as follows:");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        
        }
    }
}