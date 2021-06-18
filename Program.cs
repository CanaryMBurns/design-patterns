using System;
using DesignPatterns.Pattern.Structural.Adapter;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // Adapter
            Target target = new Adapter();
            target.Request();

            // Adapter example
            
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
