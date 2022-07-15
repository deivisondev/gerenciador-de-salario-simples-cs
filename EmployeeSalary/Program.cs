using System;
using System.Globalization;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {employee}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            employee.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"\nDados atualizados: {employee}");
        }
    }
}
