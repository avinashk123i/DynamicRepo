using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Builder
{
    public class Director
    {
        private Ibuilder _builder;

        public Ibuilder builder
        { set { _builder = value; } }

        public void BuildFullPerson()
        {
            _builder.PersonWithAddress("Address");
            _builder.PersonWithId(1);
            _builder.PersonWithAge(11);
           
        }
    }
}
