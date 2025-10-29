using System.Collections.Generic;
using GenericsPlayground.Domain;

namespace GenericsPlayground.Repository
{
    public interface IStore<T> where T : Entity, class
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void SaveChanges();
    }
}