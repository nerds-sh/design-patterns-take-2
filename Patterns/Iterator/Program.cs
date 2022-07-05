using System;
namespace Patterns.Iterator;


public class Program
    {
        static void Main()
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Elempoyees("Mihai", 1));
            collection.AddEmployee(new Elempoyees("Alin", 2));
            collection.AddEmployee(new Elempoyees("Bogdan", 3));
            collection.AddEmployee(new Elempoyees("Gabriela", 4));
            collection.AddEmployee(new Elempoyees("Andreea", 5));
            
            Iterator iterator = collection.CreateIterator();     
            Console.WriteLine("Iterating over collection:");
            
            for (Elempoyees employeess = iterator.First(); !iterator.IsCompleted; employeess = iterator.Next())
            {
                Console.WriteLine($"ID : {employeess.ID} & Name : {employeess.Name}");
            }
            Console.Read();
        }
    }