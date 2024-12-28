using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.Relationships
{
    public class Employee
    {
        public void GetManagerName(Manager managerInfo)
        {
            managerInfo.ManagerInfo(this); 
        }

    }

    public class Manager
    {
        public void ManagerInfo(Employee emp)
        {
            Console.WriteLine($"");
        }
    }
}
