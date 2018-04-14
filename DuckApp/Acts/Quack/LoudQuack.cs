using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Acts.Quack
{
    class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I quack loudly. People hates me :(");
        }
    }
}
