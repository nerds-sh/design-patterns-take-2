using System;
namespace Patterns.AdapterClasses;

class Program
    {
        public static void Run()
        {
            string[,] employeesArray = new string[5, 3] 
            {
                {"1","Mihai","12554"},
                {"2","Alin","6112"},
                {"3","Bogdan","6122"},
                {"4","Gabriela","7142"},
                {"5","Andreaa","9112"}
            };
            
            ITarget target = new EmployeeAdapter();
            target.ProcessSalary(employeesArray);
            Console.Read();   
        }
    }