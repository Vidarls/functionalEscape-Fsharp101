using System.Collections.Generic;
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

        [Theory, AutoData]
        public void Two_fsarp_records_with_the_same_names_should_be_equal(string lastName, string firstName)
        {
            var nameInstanceOne = new Fs.Name(lastName, firstName);
            var nameInstanceTwo = new Fs.Name(lastName, firstName);

            Assert.Equal(nameInstanceOne, nameInstanceTwo);
        }

        [Fact]
        public void Two_names_can_be_sorted_alphabetically()
        {
            var nameStartinWithA = new Name("Asserson", "Anders");
            var nameStaringWithÅ = new Name("Ånestad", "Åge");

            var list = new List<Name>
                {
                    nameStaringWithÅ,
                    nameStartinWithA
                };
            Assert.Equal(nameStaringWithÅ, list[0]);
            Assert.Equal(nameStartinWithA, list[1]);

            list.Sort();

            Assert.Equal(nameStartinWithA, list[0]);
            Assert.Equal(nameStaringWithÅ, list[1]);
        }

        [Fact]
        public void Two_fsharp_records_can_be_sorted_alphabetically()
        {
            var nameStartinWithA = new Fs.Name("Asserson", "Anders");
            var nameStaringWithÅ = new Fs.Name("Ånestad", "Åge");

            var list = new List<Fs.Name>
                {
                    nameStaringWithÅ,
                    nameStartinWithA
                };
            Assert.Equal(nameStaringWithÅ, list[0]);
            Assert.Equal(nameStartinWithA, list[1]);

            list.Sort();

            Assert.Equal(nameStartinWithA, list[0]);
            Assert.Equal(nameStaringWithÅ, list[1]);
        }
    }
}
