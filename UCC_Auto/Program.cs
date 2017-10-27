using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.getData();

            employee.displayStaffInfo();

            employee.getInsurance().Pay(18000);

            employee.displayStaffInfo();

            //int count = 1;
            //while (count <= 4)
            //{
            //    Employee e = new Employee();
            //    e.getData();
            //    e.displayStaffInfo();
            //    count++;
            //}

            Console.ReadKey();
        }
    }
}
