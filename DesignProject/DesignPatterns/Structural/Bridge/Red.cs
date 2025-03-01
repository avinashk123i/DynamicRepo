using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Bridge
{
    public class Red : Shaper
    {
        // If I want to call this class method I will first do new Red("either Circle or Square")
        // then I will call the GetShape Method..

        public Red(IShapeShifter shifter) : base(shifter) 
        {
            
        }
        public override void GetShape()
        {
            _shifter.GetShape("Red");
        }
    }
}
