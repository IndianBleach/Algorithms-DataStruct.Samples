using System.Collections;

namespace Structs
{
    public class DynamicArrayQueue<T>
    {
        private T[] _items;
        private int _count;

        public DynamicArrayQueue(params T[] elems)
        {
            _count = elems.Count();

            _items = new T[_count];
            
            for(int i = 0; i < _count;i++)
                _items[i] = elems[i];
        }

        private void ResizeWithElems(params T[] elems)
        {
            int elemsCount = elems.Count();

            T[] tmp = new T[elemsCount + _count];

            int curElem = 0;

            for(;curElem < _count; curElem++)
                tmp[curElem] = _items[curElem];

            for(int j = 0;j < elemsCount; j++,curElem++)
                tmp[curElem] = elems[j];

            _items = tmp;            
        }

        public void Enqueue(params T[] elems)
        {
            ResizeWithElems(elems);

            _count++;
        }

        public void Dequeue()
        {   
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T[] arr = new T[_count--];

            for(int i = 0; i < _count; i++)
                arr[i] = _items[i+1];
            
            _items = arr;
        }

        public T Top()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return _items[0]; 
        }

        public bool IsEmpty()
            => _count == 0;
    }
}