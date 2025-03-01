using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Abstract
{
    public abstract class Transport
    {
        //Thats the main creator class in here it declares the method to be overriden during creation
        // of different concreate creator of different implementations.
        public abstract Ilogistics GetLogistics();

    }
}
