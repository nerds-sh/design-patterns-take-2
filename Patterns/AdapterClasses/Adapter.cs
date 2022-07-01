using System;
namespace Patterns.AdapterClasses;

public class EmployeeAdapter : ITarget
    {
        BillingSystem billingSystem = new BillingSystem();
        
        public void ProcessSalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Salary = null;

            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary)));
            }
            billingSystem.ProcessSalary(listEmployee);
        }
    }