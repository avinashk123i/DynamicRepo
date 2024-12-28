using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class RedColor : Ivehicle
    {
        public void StartVehicle(string car)
        {
            Console.WriteLine($"starting a Red {car} car");
        }
    }
}
