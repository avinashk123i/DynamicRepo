using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class Electric : Vehicle
    {
        private Ivehicle _vehicle;
        public Electric(Ivehicle vehicle) : base(vehicle)
        {
            _vehicle = vehicle;
        }
        public override void StartVehicle()
        {

            _vehicle.StartVehicle("Electric");
        }
    }
}
