using System;
namespace Patterns.Iterator;

public class Elempoyees
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Elempoyees(string name, int id)
    {
        Name = name;
        ID = id;
    }
}