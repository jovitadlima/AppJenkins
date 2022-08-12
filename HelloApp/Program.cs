using System;
using MyCalc;
namespace HelloApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.WriteLine("It is a rainy day");
            Calc calc = new Calc();
            Console.WriteLine($"Sum={calc.Add(70,80)}");
            Console.WriteLine($"Multiply={calc.Multiply(4, 5)}");
            Console.WriteLine($"Substract={calc.Substract(10, 5)}");
            Console.ReadLine();

        }
    }
}
