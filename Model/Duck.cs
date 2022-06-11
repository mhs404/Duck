using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckConsole.Interface;

namespace DuckConsole.Model
{
    public class Duck
    {
        public Duck(IQuacking quacking, IFlying flying)
        {
            _quacking = quacking;
            _flying = flying;
        }

        private IQuacking _quacking;

        private IFlying _flying;

        public void SetQuackType(IQuacking quacking)
        {
            _quacking= quacking;
        }
        public void SetFlyType(IFlying flying)
        {
            _flying = flying;   
        }

        public void Fly()
        {
            _flying.ExecuteFlying();
        }

        public void Quack()
        {
            _quacking.ExecuteQuacking();
        }
    }
}
