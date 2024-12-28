using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public abstract class Vehicle
    {
        private Ivehicle _vehicle;
        public Vehicle(Ivehicle vehicle)
        {
            _vehicle = vehicle;      
        }


        public abstract void StartVehicle();
        
    }
}
