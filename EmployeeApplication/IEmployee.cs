using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal interface IEmployee
    {
      
            string Firstname();
        string Lastname();
        string Departmen();
        string JobTitle();
        double basicSalary();
        void computeSalary(int hoursWorked, double ratePerHour);
        double getSalary();
    
}
}
