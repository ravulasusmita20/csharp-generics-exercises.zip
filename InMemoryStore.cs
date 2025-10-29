using System.Collections.Generic;
using System.Linq;
using GenericsPlayground.Domain;

namespace GenericsPlayground.Repository
{
    public class InMemoryStore<T> : IStore<T> where T : Entity, class
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            if (item.Id == 0) item.Id = _items.Count == 0 ? 1 : _items.Max(x => x.Id) + 1;
            _items.Add(item);
        }

        public void Remove(T item) => _items.Remove(item);

        public IEnumerable<T> GetAll() => _items;

        public T? GetById(int id) => _items.FirstOrDefault(x => x.Id == id);

        public void SaveChanges() { /* no-op for memory */ }
    }
}