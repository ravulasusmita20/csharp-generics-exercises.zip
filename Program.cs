using System;
using GenericsPlayground.DataStructures;
using GenericsPlayground.Repository;
using GenericsPlayground.Domain;

namespace GenericsPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Playground");

            // MyStack demo
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine($"Stack count: {stack.Count()} -> pop: {stack.Pop()}");

            // MyList demo
            var list = new MyList<string>();
            list.Add("alpha");
            list.Add("beta");
            list.InsertAt("zero", 0);
            Console.WriteLine($"List[0] = {list.Find(0)}, contains beta? {list.Contains("beta")}");

            // Repository demo with InMemory store
            var store = new InMemoryStore<User>();
            var repo = new GenericRepository<User>(store);
            repo.Add(new User { Name = "Ada" });
            repo.Add(new User { Name = "Linus" });
            repo.Save();
            foreach (var u in repo.GetAll())
                Console.WriteLine($"User {u.Id}: {u.Name}");
            var byId = repo.GetById(1);
            Console.WriteLine($"GetById(1) = {byId?.Name}");
        }
    }

    public class User : Entity
    {
        public string Name { get; set; } = string.Empty;
    }
}