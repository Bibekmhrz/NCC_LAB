using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleInherit
{
    interface Iadd
    {
        int add(int a, int b);  
    }
    interface Isub
    {
        int sub(int x, int y);
    }
    interface Imul
    {
        int mul(int r, int s);
    }
    interface Idiv
    {
        int div(int c, int d);
    }
    class Calc : Iadd, Isub, Imul, Idiv
    {
        public int result1;
        public int add ( int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Calc c = new Calc();
                c.add(5, 8);
                c.sub(15, 1);
                c.mul(26, 3);
                c.div(9, 3);
                Console.WriteLine("This Is Multiple Inheritance Using Interface");
                Console.WriteLine("Result of Addition: " + c.result1);
                Console.WriteLine("Result of Subtraction: " + c.result2);
                Console.WriteLine("Result of Multiply: " + c.result3);
                Console.WriteLine("Result of Division: " + c.result4);
                Console.ReadKey();
            }
        }
    }
}