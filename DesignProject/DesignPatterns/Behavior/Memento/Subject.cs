using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Memento
{
    public class Subject
    {
        public string text;
        
        public Memento Save()
        {
            return new Memento(this.text);
        }


        public void RestoreState(Memento memento)
        {
            this.text = memento.content;
        }
    }
}
