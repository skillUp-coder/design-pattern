using System.Collections;
using System.Collections.Generic;

namespace Iterator.Iterator
{
    public class OrderIterator : Iterator
    {
        private readonly WordsCollection _collection;

        private int _position = -1;
        
        private readonly bool _reverse = false;

        public OrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }
        
        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }
        
        public override bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }

            return false;
        }
        
        public override void Reset()
        {
            _position = _reverse 
                ? _collection.GetItems().Count - 1 
                : 0;
        }
    }

    public class WordsCollection : IteratorAggregate
    {
        private readonly IList<string> _collection = new List<string>();

        private bool _direction = false;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        
        public IList<string> GetItems()
        {
            return _collection;
        }
        
        public void AddItem(string item)
        {
            _collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new OrderIterator(this, _direction);
        }
    }
}