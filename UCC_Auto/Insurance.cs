﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCC_Auto
{
    public class Insurance : Business
    {
        private string company;
        private double premium;
        private double payment;


        public Insurance()
        {
            this.company = "no name";
            this.premium = 0;
            this.payment = 0;
            base.setLocation("unknown");
            base.setManager("unknown");
        }

        public Insurance(string company, double premium, double payment, string location, string manager)
        {
            this.company = company;
            this.premium = premium;
            this.payment = payment;
            base.setLocation(location);
            base.setManager(manager);
        }


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

        public void Pay(double amount)
        {
            //increase the employee’s payment  here

        }

        public void setCompany(string company)
        {
            this.company = company;
        }

        public void setPayment(double payment)
        {
            this.payment = payment;
        }

        public double getBalance()
        {
            double amtOwed = premium - payment;
            if (amtOwed <= 0)
            {
                amtOwed = 0;
            }
            return amtOwed;
        }


        ~Insurance()
        {
            Console.WriteLine("Insurance closes");
        }  

    }
}
