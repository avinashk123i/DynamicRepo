using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Memento
{
    public class History
    {
        public Stack<Memento> Histor = new Stack<Memento>();

        public void SaveState(Memento memento)
        {
            Histor.Push(memento);
        }

        public Memento RestoreState() {
           return Histor.Pop();
        }

    }
}
