﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    //Insurance inherits from class Business
    public class Insurance : Business
    {
        private string company;
        private double premium;
        private double payment;


        //Default/non-parameterized Constructor
        public Insurance()
        {
            this.company = "no name";
            this.premium = 0;
            this.payment = 0;
            base.setLocation("unknown");
            base.setManager("unknown");
        }

        //Parameterized Constructor
        public Insurance(string company, double premium, double payment, string location, string manager)
        {
            this.company = company;
            this.premium = premium;
            this.payment = payment;
            base.setLocation(location);
            base.setManager(manager);
        }

        //Set Premium method that accepts two parameters
        public void setPremium(int employeeAge, double annualSalary)
        {

            //Calculate and set premium here
            if (employeeAge >= 18 && employeeAge <= 25)
            {
                premium = annualSalary * 0.10;
            }
            else if (employeeAge > 25 && employeeAge <= 50)
            {
                premium = annualSalary * 0.05;
            }
            else if (employeeAge > 50 && employeeAge < 65)
            {
                premium = annualSalary * 0.02;
            }
            else if (employeeAge >= 65)
            {
                Console.Write("This employee is retired...");
            }
            else
            {
                Console.Write("You entered an invalid age...");
            }
        }

        //This method prints the Insurance details
        public void displayInsuranceInfo()
        {
            Console.Write("\nCompany:{0} ", company);
            Console.Write("\nLocation:{0} ", base.getLocation());
            Console.Write("\nManager:{0} ", base.getManager());
            Console.Write("\nPremium:{0} ", this.premium);
            Console.Write("\nPayment:{0} ", this.payment);
            Console.Write("\nBalance:{0} \n", this.getBalance());
        }

        //Pay method that accepts amout paid and increases the employee's payment
        public void Pay(double amount)
        {
            payment += amount;

        }

        //Setter Methods
        public void setCompany(string company)
        {
            this.company = company;
        }

        public void setPayment(double payment)
        {
            this.payment = payment;
        }

        //Getter Methods
        //getBalance() return amount awed based on the payment and premium
        public double getBalance()
        {
            double amtOwed = premium - payment;
            if (amtOwed <= 0)
            {
                amtOwed = 0;
            }
            return amtOwed;
        }

        public double getPremium()
        {
            return this.premium;
        }

        //Destructor
        ~Insurance()
        {
            Console.WriteLine("Insurance closes");
        }

    }
}
