using System;
namespace Patterns.Iterator;

interface AbstractCollection
{
    Iterator CreateIterator();
}