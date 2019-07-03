using FluentAssertions;
using NUnit.Framework;

namespace SignPathTestProject.Tests
{
  [TestFixture]
  public class Class1Test
  {
    [Test]
    public void Foo()
    {
      var sut = new Class1();

      // ACT
      var result = sut.Foo();

      // ASSERT
      result.Should().Be("Bar");
    }
  }
}
