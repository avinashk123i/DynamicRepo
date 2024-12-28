using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Iterator
{
    public class PropertyEnumerator : IEnumerator
    {

        private string[] Props { get; set; }
        private int index = -1;


        public PropertyEnumerator(string[] props)
        {
            Props = props;
        }

        public object Current => Props[index];

        public bool MoveNext()
        {
           index++;
           return index < Props.Length;
            
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
