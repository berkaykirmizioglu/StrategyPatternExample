using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Acts.Quack
{
    class QuiteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I quack quitely. People loves me <3");
        }
    }
}
