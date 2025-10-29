using System;
using System.Collections.Generic;

namespace GenericsPlayground.DataStructures
{
    public class MyList<T>
    {
        private T[] _data = new T[4];
        private int _count;
        public int Count => _count;

        private void EnsureCapacity(int needed)
        {
            if (needed <= _data.Length) return;
            int newCap = Math.Max(_data.Length * 2, needed);
            Array.Resize(ref _data, newCap);
        }

        public void Add(T element)
        {
            EnsureCapacity(_count + 1);
            _data[_count++] = element;
        }

        public T Remove(int index)
        {
            CheckIndex(index);
            T removed = _data[index];
            for (int i = index; i < _count - 1; i++) _data[i] = _data[i + 1];
            _data[--_count] = default!;
            return removed;
        }

        public bool Contains(T element)
        {
            var cmp = EqualityComparer<T>.Default;
            for (int i = 0; i < _count; i++)
                if (cmp.Equals(_data[i], element)) return true;
            return false;
        }

        public void Clear()
        {
            Array.Clear(_data, 0, _count);
            _count = 0;
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > _count) throw new ArgumentOutOfRangeException(nameof(index));
            EnsureCapacity(_count + 1);
            for (int i = _count; i > index; i--) _data[i] = _data[i - 1];
            _data[index] = element;
            _count++;
        }

        public void DeleteAt(int index) => Remove(index);

        public T Find(int index)
        {
            CheckIndex(index);
            return _data[index];
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}