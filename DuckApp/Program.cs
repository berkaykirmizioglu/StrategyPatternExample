using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckApp.Duck;

namespace DuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CityDuck cityDuck = new CityDuck();

            cityDuck.PerformDisplay();
            cityDuck.PerformFly();
            cityDuck.PerformQuack();

            MountainDuck mountaintDuck = new MountainDuck();

            mountaintDuck.PerformDisplay();
            mountaintDuck.PerformFly();
            mountaintDuck.PerformQuack();
        }
    }
}
