using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Strategy
{
    public class Strategy
    {
        public IContext _state;

        public Strategy()
        {
            
        }
        public Strategy(IContext state)
        {
            _state = state;
        }


        public void SetStrategy(IContext state)
        {
            this._state = state;
        }


        public void DoOperation()
        {
            _state.Operation();
        }

    }


    public interface IContext
    {
        public void Operation();
    }


    public class SuperClass : IContext
    {
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }



    public class SuperClassB : IContext
    {
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }


}
