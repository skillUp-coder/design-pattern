using System.Collections;

namespace Iterator.Iterator
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key(); 
        public abstract object Current();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();
    }
    
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}