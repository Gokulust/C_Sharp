using FluentAssertions;

namespace ValueTypes.Tests.Unit
{
    public class ObjectTypeTests
    {
        Customer _sut =new Customer();

        [Fact]

        public void ObjectAssertion()
        {
            var expectedCustomer = new Customer { name = "gokul", age = 12 };

           _sut.Should().BeEquivalentTo(expectedCustomer);

        }
    }
}
