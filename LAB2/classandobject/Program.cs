using System;
namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int result = cal.CalculateSum(200, 1500);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class Calculator
    {
        public int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}