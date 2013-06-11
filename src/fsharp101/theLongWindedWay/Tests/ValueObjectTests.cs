using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

// ReSharper disable InconsistentNaming
namespace theLongWindedWay.Tests
{
    public class ValueObjectTests
    {
        [Theory, AutoData]
        public void Two_objects_with_the_same_names_should_be_equal(string lastName, string firstName)
        {
            var nameInstanceOne = new Name(lastName, firstName);
            var nameInstanceTwo = new Name(lastName, firstName);

            Assert.Equal(nameInstanceOne, nameInstanceTwo);
        }
    }
}
