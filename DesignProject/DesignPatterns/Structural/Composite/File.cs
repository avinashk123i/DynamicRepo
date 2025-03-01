using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public class File : IFolderVision
    {
        private readonly string _name;
        public File(string name)
        {
            _name = name;
        }

        public void Display(string intend = "")
        {
            Console.WriteLine($"{intend} - {_name}");
        }
    }
}
