using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class Projector
    {
        public void AdjustBrightness(string brightness)
        {
            Console.WriteLine($"Brightness of the projector adjust to {brightness}");
        }



    }
}
