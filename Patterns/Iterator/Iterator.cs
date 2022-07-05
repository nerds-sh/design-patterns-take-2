using System;
namespace Patterns.Iterator;

class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        public Elempoyees First()
        {
            current = 0;
            return collection.GetEmployees(current);
        }
        public Elempoyees Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployees(current);
            }
            else
            {
                return null;
            }
        }
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }