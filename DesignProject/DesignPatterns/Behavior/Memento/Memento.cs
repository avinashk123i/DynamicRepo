using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Memento
{
    public class Memento
    {
        public string content;
        public Memento(string content)
        {
            this.content = content;
        }


    }
}
