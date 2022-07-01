using System;
namespace Patterns.AdapterClasses;

public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, decimal salary)
        {
            ID = id;
            Name = name;
            Salary = salary; 
        }
    }