using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public abstract class Shaper
    {
        public readonly IShapeShifter _shifter;

        public Shaper(IShapeShifter shifter)
        {
            _shifter = shifter;
        }

        public abstract void GetShape();


    }
}
