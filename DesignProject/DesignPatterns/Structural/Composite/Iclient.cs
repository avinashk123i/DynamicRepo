using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Composite
{
    public abstract class Iclient
    {
        public abstract bool isComposite();

        public abstract string DoOperation();


        public virtual void Add(Iclient client)
        {

        }


        public virtual void Remove(Iclient client) { 

        }

    }
}
