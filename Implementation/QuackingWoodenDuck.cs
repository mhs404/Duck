using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckConsole.Interface;

namespace DuckConsole.Implementation
{
    public class QuackingWoodenDuck : IQuacking
    {
        public void ExecuteQuacking()
        {
            Console.WriteLine("I cannot quack!");
        }
    }
}
