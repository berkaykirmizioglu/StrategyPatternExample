using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Acts.Flying
{
    class LowFly : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly low :(");
        }
    }
}
