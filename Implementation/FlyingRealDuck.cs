using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckConsole.Interface;

namespace DuckConsole.Implementation
{
    public class FlyingRealDuck : IFlying
    {
        public void ExecuteFlying()
        {
            Console.WriteLine("Flying high !");
        }
    }
}
