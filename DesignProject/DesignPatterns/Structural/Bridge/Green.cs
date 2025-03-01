using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class Green : Shaper
    {
        
        public Green(IShapeShifter shifter) : base(shifter)
        {
            
        }
        public override void GetShape()
        {
            _shifter.GetShape("Green");
        }
    }
}
