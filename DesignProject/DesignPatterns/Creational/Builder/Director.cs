using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Builder
{
    public class Director
    {
   
        public Ibuilder builder
        { get; set; }

        public void BuildFullPerson()
        {
            this.builder.PersonWithAddress("Address").PersonWithId(1).PersonWithAge(23).Build();  
        }
    }
}
