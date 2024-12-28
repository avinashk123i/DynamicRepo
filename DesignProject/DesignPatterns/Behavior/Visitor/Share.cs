using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Visitor
{

    public class Circle : IShape
    {
        public void Accept(Ivisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }

    public class Rectangle : IShape
    {
        public void Accept(Ivisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }


    public interface IShape
    {
        public void Accept(Ivisitor visitor);
    }


    public interface Ivisitor
    {
        public void VisitCircle(IShape shape);

        public void VisitRectangle(IShape shape);
    }


    public class ConcreteVisitor : Ivisitor
    {
        public void VisitCircle(IShape shape)
        {
            Console.WriteLine(shape.GetType().Name);
        }

        public void VisitRectangle(IShape shape)
        {
            Console.WriteLine(shape.GetType().Name);
        }
    }

}
