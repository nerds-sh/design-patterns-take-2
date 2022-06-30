using System;
namespace Patterns.Facade
{
    public class Paperwork
    {
        public bool HasAllThePaperwork(Person p)
        {
            Console.WriteLine("Check paperwork for " + p.Name);
            return true;
        }
    }
}