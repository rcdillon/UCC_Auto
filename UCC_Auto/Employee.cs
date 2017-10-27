using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    class Employee
    {
        private int idNumber;
        private string firstName;
        private string lastName;
        private double annualSalary;
        private int age;
        private Insurance insurance;

        public Employee()
        {
            
        }

        public Insurance getInsurance()
        {
            return this.insurance;
        }

        public void getData()
        {
            Console.Write("\n Enter employee ID: ");
            idNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter employee first name: ");
            firstName = Console.ReadLine();

            Console.Write("\n Enter employee last name: ");
            lastName = Console.ReadLine();

            Console.Write("\n Enter employee age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter employee annual salary: ");
            annualSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Enter insurance company: ");
            string companyName = Console.ReadLine();

            Console.Write("\n Enter the payment: ");
            double payment = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("\n Enter insurance company manager: ");
            string manager = Console.ReadLine();

            Console.Write("\n Enter insurance company location: ");
            string location = Console.ReadLine();

            this.insurance = new Insurance(companyName, 0, 0, location, manager);
            this.insurance.setPremium(this.age, this.annualSalary);
            this.insurance.Pay(payment);
        }


        public void displayStaffInfo()
        {
            //Display employee details
            Console.Write("\nEmployee ID:{0} ", idNumber);
            Console.Write("\nEmployee first name:{0} ", firstName);
            Console.Write("\nEmployee last name:{0} ", lastName);
            Console.Write("\nEmployee age:{0} ", this.age);
            Console.Write("\nEmployee retirement year:{0} ", Retirement());
            Console.Write("\nInsurance Info");
            this.insurance.displayInsuranceInfo();
        }

        public int Retirement()
        {
            //Calculate year of retirement
            int currentYear = 2017;
            int retirementYear = (65 - this.age) + currentYear;

            return retirementYear;
        }

        

    }
}
