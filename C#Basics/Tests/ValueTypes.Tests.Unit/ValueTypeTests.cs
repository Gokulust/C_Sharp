using FluentAssertions;
namespace ValueTypes.Tests.Unit
{
    public class ValueTypeTests
    {
        Person _sut = new Person();
        [Fact]
        public void StringAssertion()
        {
            var name =_sut.Name;
            _sut.Name = "Rithu";

            name.Should().Be("Gokul");
            name.Should().NotBeNull();
            name.Should().NotBeEmpty();
            name.Should().StartWith("Rithu");
            name.Should().EndWith("u");
        }
    }
}