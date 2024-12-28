using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Oberver.Simple
{
    public class A 
    {

        public List<ISubject> subjects = new List<ISubject>();

        public void Attach(ISubject subject)
        {
            subjects.Add(subject);
        }

        public void Remove(ISubject subject)
        {
            subjects.Remove(subject);   
        }

    }
}
