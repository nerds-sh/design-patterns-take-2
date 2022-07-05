using System;
namespace Patterns.Iterator;

class ConcreteCollection : AbstractCollection
{
    private List<Elempoyees> listEmployees = new List<Elempoyees>();
    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }
    public int Count
    {
        get { return listEmployees.Count; }
    }
    public void AddEmployee(Elempoyees employees)
    {
        listEmployees.Add(employees);
    }
    public Elempoyees GetEmployees(int IndexPosition)
    {
        return listEmployees[IndexPosition];
    }
}