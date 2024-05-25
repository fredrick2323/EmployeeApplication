using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee
    {
        
        private string FName;
        private string LName;
        private string Dept;
        private string job;
        private double basicsalary;


        public string Firstname
        {

            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public string Department
        {
            get
            {
                return Dept;
            }
            set
            {
                Dept = value;
            }
        }
        public double basicSalary
        {
            get
            {
                return basicsalary;
            }
            set
            {
                basicsalary = value;
            }
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basicsalary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return basicsalary;

        }
        public PartTimeEmployee(string fname, string lname, string Dept, string job)
        {
            this.FName = fname;
            this.LName = lname;
            this.Dept = Dept;
            this.job = job;

        }
    }
}
