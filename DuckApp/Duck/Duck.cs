using DuckApp.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.Duck
{
    public abstract class ADuck
    {
        IFlyingBehavior fb;
        IQuackBehavior qb;
        IDisplayBehavior db;

        public ADuck()
        {

        }

        public void setFlyBehavior(IFlyingBehavior fb) 
        {
            this.fb = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            this.qb = qb;
        }

        public void setDisplayBehavior(IDisplayBehavior db)
        {
            this.db = db;
        }

        public void PerformFly()
        {
            fb.Fly();
        }

        public void PerformQuack()
        {
            qb.Quack();
        }

        public void PerformDisplay()
        {
            db.Display();
        }
    }
}
