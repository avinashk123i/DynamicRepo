using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class Circle : IShapeShifter
    {
        public string GetShape(string color)
        {
            return $"Adding {color} colored circle here";
        }
    }
}
