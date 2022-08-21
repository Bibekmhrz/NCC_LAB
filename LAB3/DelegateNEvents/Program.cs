using System;
namespace Delegates
{
    public delegate int operation(int x, int y);

    class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            operation obj = new operation(Program.Addition);

            Console.WriteLine("Result of Addition is {0}", obj(500, 800));
            Console.ReadLine();
        }
    }
}