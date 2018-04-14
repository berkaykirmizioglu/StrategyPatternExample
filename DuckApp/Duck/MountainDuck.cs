using DuckApp.Acts.Display;
using DuckApp.Acts.Flying;
using DuckApp.Acts.Quack;
using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Duck
{
    class MountainDuck : ADuck
    {
        public MountainDuck()
        {
            setFlyBehavior(new HighFly());
            setQuackBehavior(new LoudQuack());
            setDisplayBehavior(new FakeDisplay());
        }
    }
}
