using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Builder
{
    public interface Ibuilder
    {
        public Builder PersonWithAddress(string address);

        public Builder PersonWithId(int Id);

        public Builder PersonWithAge(int age);

    }
}
