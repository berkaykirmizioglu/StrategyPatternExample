using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Acts.Flying
{
    class HighFly : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly High and high");
        }
    }
}
