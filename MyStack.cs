using System;
using System.Collections.Generic;

namespace GenericsPlayground.DataStructures
{
    public class MyStack<T>
    {
        private readonly List<T> _items = new();

        public int Count() => _items.Count;

        public void Push(T item) => _items.Add(item);

        public T Pop()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Stack is empty.");
            int last = _items.Count - 1;
            var value = _items[last];
            _items.RemoveAt(last);
            return value;
        }
    }
}