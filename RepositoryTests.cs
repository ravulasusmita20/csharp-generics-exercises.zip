using FluentAssertions;
using GenericsPlayground.Domain;
using GenericsPlayground.Repository;
using Xunit;

namespace GenericsPlayground.Tests
{
    public class RepositoryTests
    {
        class Widget : Entity
        {
            public string Name { get; set; } = string.Empty;
        }

        [Fact]
        public void Add_GetAll_GetById_Remove_Save()
        {
            var store = new InMemoryStore<Widget>();
            var repo = new GenericRepository<Widget>(store);

            var w1 = new Widget { Name = "one" };
            var w2 = new Widget { Name = "two" };
            repo.Add(w1);
            repo.Add(w2);
            repo.Save();

            repo.GetAll().Should().HaveCount(2);
            repo.GetById(w1.Id)!.Name.Should().Be("one");

            repo.Remove(w2);
            repo.GetAll().Should().HaveCount(1);
        }
    }
}