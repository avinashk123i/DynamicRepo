using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory.Mac
{
    public class MacCheckBox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Check box is checked");
        }
    }
}
