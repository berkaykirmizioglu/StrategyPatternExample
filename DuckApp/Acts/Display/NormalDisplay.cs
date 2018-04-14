using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Acts.Display
{
    class NormalDisplay : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("I am a good looking Duck");
        }
    }
}
