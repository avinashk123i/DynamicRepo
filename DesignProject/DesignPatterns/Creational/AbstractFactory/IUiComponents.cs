using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Creational.AbstractFactory
{
    public interface IUiComponents
    {
        //This is basically the creator interface which is going to implemented inside
        // both the families of concrete creator classes.
        public ICheckBox CreateCheckBox();
        public IButton Createbutton();
    }
}
