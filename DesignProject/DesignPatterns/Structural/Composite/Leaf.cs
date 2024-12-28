using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public class Leaf : Iclient
    {
        public override string DoOperation()
        {
            return "leaf";
        }

        public override bool isComposite()
        {
            return false;
        }
    }
}
