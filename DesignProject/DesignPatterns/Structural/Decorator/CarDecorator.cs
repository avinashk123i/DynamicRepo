using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Decorator
{
    public abstract class CarDecorator : ICar
    {
        public ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }



        public virtual string  GetCar(string type)
        {
            return car.GetCar(type);
        }
    }
}
