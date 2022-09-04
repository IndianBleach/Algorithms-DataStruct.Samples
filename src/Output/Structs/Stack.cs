using System.Collections;
using System.Collections.Generic;

namespace Structs
{
    public class FixedStack<T>
    {
        public T TopValue;

        private const int MaxItemsCount = 5;
        
        private T[] _items;

        private int _count = 0;

        public FixedStack(int count)
            => _items = new T[count];

        public bool IsEmpty()
            => _count == 0;

        public T Pop()
        {
            if (IsEmpty())
                return default(T);

            T item = _items[--_count];
            _items[_count] = default(T);

            return item;
        }

        public void Push(T val)
        {   
            if (_count == MaxItemsCount)
                throw new InvalidOperationException("Stack have no space for new Elem");            

            _items[_count++] = val;
        }
    }
}