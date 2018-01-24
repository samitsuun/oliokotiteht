using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
   public class Employee
    {
        private int id = 1337;
        private string firstName;
        private string lastName;
        private int salary = 1300;
        private int annualSalary;

        public int getId()
        {
            return id;
        }

        public string getFirstName()
        {
            firstName = "Joonas";
            return firstName;
        }

        public string getLastName()
        {
            lastName = "Honkanen";
            return lastName;
        }

        public string getName()
        {
            return firstName + " " + lastName;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary(int newSalary)
        {
            salary = newSalary;
        }

        public int AnnualSalary()
        {
            annualSalary = salary * 12;
            return annualSalary;
        }

        public int raiseSalary(int Percent)
        {
            salary = salary + Percent;
            return salary;
        }

        public string toString()
        {
            return "id: " + getId() + "\n" + "name: " + getName() + "\n" + "salary: " + getSalary() + "\n" + "annual salary: " + AnnualSalary();
        }
    }
}
