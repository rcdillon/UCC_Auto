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
             //Creates object of class Employee
             Employee employee = new Employee();

             //Employee object calls the getData method for the user to enter the details for 
             //employee and insurance and then displays the info after
             employee.getData();
             employee.displayStaffInfo();

             //Insurance payment 
             employee.getInsurance().Pay(18000);

             //This will reflect the changes that were made
             Console.Write("\nUpdated info below...");
             employee.displayStaffInfo();

            //Pause for user to continue to loop below
            Console.Write("\nPress enter to continue...");
            Console.ReadKey();

            //This loop serves to get info for four persons
            int count = 1;
             while (count <= 4)
             {
                 Employee e = new Employee();
                 e.getData();
                 e.displayStaffInfo();
                 count++;
             }
                         
            Console.ReadKey();
        }
    }
}
