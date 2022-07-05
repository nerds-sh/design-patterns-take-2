using System;
namespace Patterns.Iterator;

interface AbstractIterator
{
    Elempoyees First();
    Elempoyees Next();
    bool IsCompleted { get; }
}
