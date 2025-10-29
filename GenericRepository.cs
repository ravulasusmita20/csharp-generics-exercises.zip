using System.Collections.Generic;
using GenericsPlayground.Domain;

namespace GenericsPlayground.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : Entity, class
    {
        private readonly IStore<T> _store;

        public GenericRepository(IStore<T> store) => _store = store;

        public void Add(T item) => _store.Add(item);

        public void Remove(T item) => _store.Remove(item);

        public void Save() => _store.SaveChanges();

        public IEnumerable<T> GetAll() => _store.GetAll();

        public T? GetById(int id) => _store.GetById(id);
    }
}