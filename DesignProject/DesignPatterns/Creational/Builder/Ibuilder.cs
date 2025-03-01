using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Builder
{
    public interface Ibuilder
    {
        public Ibuilder PersonWithAddress(string address);

        public Ibuilder PersonWithId(int Id);

        public Ibuilder PersonWithAge(int age);

        public Builder Build();

    }
}
