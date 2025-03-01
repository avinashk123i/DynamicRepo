using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class Square : IShapeShifter
    {
        public string GetShape(string color)
        {
            return $"Adding {color} colored Square here";
        }
    }
}
