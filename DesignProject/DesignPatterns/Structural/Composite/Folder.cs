using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public class Folder : IFolderVision
    {
        private List<IFolderVision> _folders = new List<IFolderVision>();
        
        private string _name;
        public Folder(string name)
        {
            _name = name;
        }

        public void add(IFolderVision parent)
        {
            _folders.Add(parent);
        }

        public void Remove(IFolderVision parent)
        {
            _folders.Remove(parent);
        }
        public void Display(string intend="")
        {
            Console.WriteLine($"{intend}+ {_name}");
            foreach (var items in _folders)
            {
                items.Display(" " + $"{intend}");
            }
        }
    }
}
