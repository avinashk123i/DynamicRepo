using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Abstract
{
    public class RoadTransport : Transport
    {
        public override Ilogistics GetLogistics()
        {
            return new Truck();
        }
    }
}
