using System;
namespace Patterns.AdapterClasses;

public class EmployeeAdapter : IEmployeeTarget
{

    private Employees _employees;

    public EmployeeAdapter(Employees employees)
    {

        _employees = employees;
    }

    public EmployeeAdapter()
    {
    }

    public string EmployeesList()
    {
        return _employees.GetEmployee();
    }

    public string EmployeeList()
    {
        throw new NotImplementedException();
    }

    IEmployeeTarget target = new EmployeeAdapter(new Employees());
}    