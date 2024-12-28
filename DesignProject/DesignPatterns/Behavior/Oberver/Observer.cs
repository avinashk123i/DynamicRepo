using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Oberver
{
    public delegate string GetEvent();
    public class Observer
    {
        public event GetEvent TestEve;


        public void TestEvent()
        {
            testA t = new testA();
            testB t2 = new testB();
            
            TestEve += t.Get;
            TestEve += t2.Get;
            TestEve -= t2.Get;

            TestEve?.Invoke();


        }

    }



    public class testA
    {
        public string Get()
        {
            return "testASAAAA";
        }
    }


    public class testB
    {
        public string Get()
        {
            return "testB";
        }
    }
}
