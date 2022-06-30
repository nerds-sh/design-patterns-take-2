using System;
namespace Patterns.AdapterClasses;

    public class bill
    {

        private IEmployeeTarget _employeeTarget;

        public bill(IEmployeeTarget employeetarget)
        {
            _employeeTarget = employeetarget;
        }

        public void ShowEmployees()
        {
            string employeesInfo = _employeeTarget.EmployeeList();
            Console.WriteLine("Employee:" + employeesInfo);
        }
    }