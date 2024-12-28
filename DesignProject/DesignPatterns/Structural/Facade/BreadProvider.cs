using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class BreadProvider : IBread
    {
        public void GetBread()
        {
            Console.WriteLine("Bread");
        }
    }
}
