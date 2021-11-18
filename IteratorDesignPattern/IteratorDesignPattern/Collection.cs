using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IteratorDesignPattern
{
    /// <summary>
    /// A classe 'ConcreteAggregate' 
    /// </summary>
    public class MinhaColecao : IAbstractCollection
    {
        List<Item> items = new List<Item>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Obter a quantidade de itens
        public int Count
        {
            get { return items.Count; }
        }
        // Indexador
        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
