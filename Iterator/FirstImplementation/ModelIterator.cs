namespace Iterator.FirstImplementation
{
    internal class ModelIterator : IModelIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public ModelIterator(Collection beans)
        {
            this._collection = beans;
        }


        public Model First()
        {
            _current = 0;
            Console.WriteLine("First");
            return _collection[_current] as Model;
        }


        public Model Next()
        {
            Console.WriteLine("Next");
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Model;
            else
            {

                Console.WriteLine("Finish");
                return null;
            }
        }


        public Model CurrentBean
        {
            get { return _collection[_current] as Model; }
        }


        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
