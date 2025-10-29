using FluentAssertions;
using GenericsPlayground.DataStructures;
using Xunit;

namespace GenericsPlayground.Tests
{
    public class MyStackTests
    {
        [Fact]
        public void PushPop_Works()
        {
            var s = new MyStack<int>();
            s.Push(10);
            s.Push(20);
            s.Count().Should().Be(2);
            s.Pop().Should().Be(20);
            s.Pop().Should().Be(10);
        }
    }
}