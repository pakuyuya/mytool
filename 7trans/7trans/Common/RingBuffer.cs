using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7trans.Common
{
    class RingBuffer<T>
    {

        private int _size = 0;
        private int _bottom = -1;
        private int _head = -1;
        T[] _buf;

        public RingBuffer(int size)
        {
            _buf = new T[size];
            _size = size;
            _head = -1;
            _bottom = -1;
        }

        public void Push(T item)
        {
            int nextIdx = (_head + 1) % _size;
            if (_bottom == nextIdx)
            {
                _bottom = (_bottom + 1) % _size;
            }
            if (_bottom < 0)
            {
                _bottom = 0;
            }

            _head = nextIdx;
            _buf[nextIdx] = item;
        }

        public T Pop()
        {
            if (_head == _bottom)
            {
                throw new InvalidOperationException("Can't pop, [Cause] a ring buffer is empty.");
            }
            int nextIdx = (_head + _size - 1) % _size;
            
            if (nextIdx == _bottom)
            {
                _head = _bottom = -1;
            }
            else
            {
                _head = nextIdx;
            }

            return _buf[nextIdx];
        }

        public bool IsEmpty { get { return _bottom == _head; } }
    }
}
