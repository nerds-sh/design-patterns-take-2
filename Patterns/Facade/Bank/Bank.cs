using System;
namespace Patterns.Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Person p)
        {
            Console.WriteLine("Check bank for " + p.Name);
            return true;
        }
    }
}