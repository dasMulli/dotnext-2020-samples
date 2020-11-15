using System;

namespace CodeGenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{BuildVariables.Greeting} {BuildVariables.Name}!");
            Console.ReadLine();
        }
    }
}
