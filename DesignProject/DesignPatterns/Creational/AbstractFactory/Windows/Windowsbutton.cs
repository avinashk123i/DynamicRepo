using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory.Windows
{
    public class Windowsbutton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows button is pressed");
        }
    }
}
