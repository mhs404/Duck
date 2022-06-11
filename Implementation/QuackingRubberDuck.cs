using System;
using System.Media;
using DuckConsole.Interface;

namespace DuckConsole.Implementation
{
    public class QuackingRubberDuck : IQuacking
    {
        public void ExecuteQuacking()
        {
            Console.WriteLine("Beep Beep !");
        }
    }
}
