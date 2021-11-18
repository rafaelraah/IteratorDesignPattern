using System;

namespace IteratorDesignPattern
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
