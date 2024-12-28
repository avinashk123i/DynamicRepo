using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Iterator
{
    public class Property : IEnumerable
    {

        private readonly string[] _enumerator;

        public Property(string[] enumerator)
        {
            _enumerator = enumerator;
        }

        public IEnumerator GetEnumerator()
        {
            return new PropertyEnumerator(_enumerator);
        }
    }

}
