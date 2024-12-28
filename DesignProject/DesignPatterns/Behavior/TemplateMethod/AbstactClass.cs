using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.TemplateMethod
{
    public abstract class AbstactClass
    {
        
        protected AbstactClass()
        {
            
        }


        public void TemplateMethod()
        {
            this.operationB();
            this.OperationC();  
            this.operationA();

        }



        public void operationA()
        {

        }


        public void operationB()
        {

        }

        public abstract void OperationC();
    }
}
