using System;
namespace Patterns.AdapterClasses;

public interface IEmployeeTarget {
    string EmployeeList();
}

public class Employees {

    public string GetEmployee(){
        return "Mr. X, CEO";
    }
}