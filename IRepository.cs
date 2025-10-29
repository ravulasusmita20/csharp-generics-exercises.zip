using System.Collections.Generic;
using GenericsPlayground.Domain;

namespace GenericsPlayground.Repository
{
    public interface IRepository<T> where T : Entity, class
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T? GetById(int id);
    }
}