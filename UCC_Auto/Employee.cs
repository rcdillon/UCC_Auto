using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    class Employee
    {
        //Employee class data members
        private int idNumber;
        private string firstName;
        private string lastName;
        private double annualSalary;
        private int age;

        //This indicates that Employee has insurance through the uses of composition
        private Insurance insurance;

        //Default/non-parameterized Constructor
        public Employee()
        {

        }

        //Getter Methods
        public Insurance getInsurance()
        {
            return this.insurance;
        }

        //This method allow the user to input deatails for employee and insurance
        public void getData()
        {
            string companyName = "", manager = "", location = "", errorMessage = "";
            double payment = 0;
            bool valid = false;

            //Looping until data entered is valid
            while (!valid)
            {
                //Check for invalid data and displays appropriate error message
                try
                {
                    Console.Clear();

                    errorMessage = "Invalid Employee ID Number...";
                    Console.Write("\n Enter employee ID: ");
                    idNumber = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("\n Enter employee first name: ");
                    firstName = Console.ReadLine();
                    
                    Console.Write("\n Enter employee last name: ");
                    lastName = Console.ReadLine();

                    errorMessage = "Invalid Employee Age...";
                    Console.Write("\n Enter employee age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    errorMessage = "Invalid Format Entered...";
                    Console.Write("\n Enter employee annual salary: ");
                    annualSalary = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("\n Enter insurance company: ");
                    companyName = Console.ReadLine();

                    errorMessage = "Invalid Format Entered...";
                    Console.Write("\n Enter the payment: ");
                    payment = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("\n Enter insurance company manager: ");
                    manager = Console.ReadLine();
                    
                    Console.Write("\n Enter insurance company location: ");
                    location = Console.ReadLine();

                    valid = true;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine(errorMessage);
                    Console.ReadKey();
                }
            }

            this.insurance = new Insurance(companyName, 0, 0, location, manager);
            this.insurance.setPremium(this.age, this.annualSalary);
            this.insurance.Pay(payment);
        }

        //This method prints the Employee and Insurance info
        public void displayStaffInfo()
        {

            Console.Write("\nEmployee ID:{0} ", idNumber);
            Console.Write("\nEmployee first name:{0} ", firstName);
            Console.Write("\nEmployee last name:{0} ", lastName);
            Console.Write("\nEmployee age:{0} ", this.age);
            Console.Write("\nEmployee retirement year:{0} ", Retirement());
            Console.Write("\n\nInsurance Info");
            this.insurance.displayInsuranceInfo();
        }

        //This method calculates the year of retirement
        public int Retirement()
        {
            int currentYear = 2017;
            int retirementYear = (65 - this.age) + currentYear;

            return retirementYear;
        }



    }
}
