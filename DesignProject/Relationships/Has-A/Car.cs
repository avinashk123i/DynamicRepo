using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Relationships.Has_A
{
    public class Car
    {
        public string CarName { get; set; }
    }

    public class Suzuki : Car
    {
        public void EngineInfo()
        {
            EngineInfo eng = new EngineInfo();
            eng.Engine();

           var cc =  typeof(int);
        }

    }


    public class EngineInfo
    {
     public void Engine()
        {
            Console.WriteLine("4 stroke petrol engine");
        }
    }
}
