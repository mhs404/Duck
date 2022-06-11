using System;
using System.Media;
using DuckConsole.Interface;

namespace DuckConsole.Implementation
{
    public class QuackingRealDuck : IQuacking
    {
        public void ExecuteQuacking()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}
