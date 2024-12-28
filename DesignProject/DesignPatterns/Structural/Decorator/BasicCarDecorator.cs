using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Decorator
{
    public class BasicCarDecorator : CarDecorator
    { 
        private readonly ICar _car;

        public BasicCarDecorator(ICar car) : base(car)
        {
            _car = car;
        }

        public override string GetCar(string type)
        {
           return "Basic" + base.GetCar(type) ;
        }
    }
}
