using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.State
{
    public class Order
    {
        private Istate state;
        public Order(Istate state)
        {
            this.state = state;
        }

        public void setState(Istate state)
        {
            this.state = state;
        }

    }

    public interface Istate
    {
        public void handle();

        public void SetNextState(Order order);
    }


    public class OrderedState : Istate
    {
        public void handle()
        {
            Console.WriteLine("Ordered a product");
        }
            public void SetNextState(Order order)
        {
            order.setState(new ShippedState());
        }
    }

    public class ShippedState : Istate
    {
        public void handle()
        {
            Console.WriteLine("Shipped the product");
        }

        public void SetNextState(Order order)
        {
            Console.WriteLine("");
        }
    }
}
