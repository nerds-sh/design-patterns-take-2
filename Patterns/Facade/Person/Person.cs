using System;
namespace Patterns.Facade
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}