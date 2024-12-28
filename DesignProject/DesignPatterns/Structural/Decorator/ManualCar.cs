using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Decorator
{
    public class ManualCar : ICar
    {
        public string GetCar(string type)
        {
            return ($"Get {type} Manual car");
        }
    }
}
