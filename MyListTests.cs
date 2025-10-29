using FluentAssertions;
using GenericsPlayground.DataStructures;
using Xunit;

namespace GenericsPlayground.Tests
{
    public class MyListTests
    {
        [Fact]
        public void Add_Insert_Find_Remove()
        {
            var l = new MyList<string>();
            l.Add("a");
            l.Add("b");
            l.InsertAt("x", 1);
            l.Find(0).Should().Be("a");
            l.Find(1).Should().Be("x");
            l.Contains("b").Should().BeTrue();
            l.Remove(1).Should().Be("x");
            l.DeleteAt(1); // deletes "b"
            l.Count.Should().Be(1);
        }
    }
}