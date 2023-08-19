using System.Collections;

namespace Iterator.FirstImplementation
{
    internal class Collection : ICollection
    {
        private ArrayList _items = new ArrayList();

        public ModelIterator CreateCollectionIterator()
        {
            return new ModelIterator(this);
        }

        
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
