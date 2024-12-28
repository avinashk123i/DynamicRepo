using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Abstract
{
    public class ConcreateCreatorB : CreatorNew
    {
        public override IProductNew getProduct()
        {
            return new ProductNewB();
        }
    }
}
