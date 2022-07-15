using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Employee
    {
        public string? Name;
        public double GrossSalary;
        public double Tax;

        public void IncreaseSalary(double porcentage)
        {
            GrossSalary += (GrossSalary * porcentage) / 100;
        }

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
