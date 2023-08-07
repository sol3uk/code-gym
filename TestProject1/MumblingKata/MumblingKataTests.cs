using System.Text;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [TestFixture]
    public class People
    {
        [Test]
        public void GivenAListOfPeopleWhenFilteredThenAllAgesShouldBeGreaterOrEqualTo18()
        {
            var employees = new List<MumblingUsings.Person>
            {
                new("Max", 17),
                new("Sepp", 18),
                new("Nina", 15),
                new("Mike", 51)
            };
            var expectedEmployees = new List<MumblingUsings.Person>
            {
                new("Sepp", 18),
                new("Mike", 51)
            };

            var result = MumblingUsings.FilterAge(employees);

            Assert.That(result.All(person => person.age >= 18));
            Assert.That(expectedEmployees.Count, Is.EqualTo(result.Count));
        }

        [Test]
        public void GivenAListOfPeopleWhenFilteredThenAllNamesShouldBeInDescendingOrder()
        {
            var employees = new List<MumblingUsings.Person>
            {
                new("Max", 17),
                new("Sepp", 18),
                new("Nina", 15),
                new("Mike", 51)
            };
            var expectedEmployees = new List<MumblingUsings.Person>
            {
                new("SEPP", 18),
                new("MIKE", 51),
            };

            var result = MumblingUsings.FilterAge(employees);

            Assert.That(expectedEmployees, Is.EqualTo(result));
        }

        [Test]
        public void GivenAListOfPeopleWhenFilteredThenAllNamesShouldBeInCaps()
        {
            var employees = new List<MumblingUsings.Person>
            {
                new("Max", 17),
                new("Sepp", 18),
                new("Nina", 15),
                new("Mike", 51)
            };
            var expectedEmployees = new List<MumblingUsings.Person>
            {
                new("MIKE", 51),
                new("SEPP", 18),
            };

            var result = MumblingUsings.FilterAge(employees);

            Assert.That(expectedEmployees, Is.EquivalentTo(result));
        }
    }

    [TestFixture]
    public class Mumble
    {
        [TestCase("abcd", "A-Bb-Ccc-Dddd")]
        [TestCase("RqaE4zty", "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy")]
        [TestCase("cw At", "C-Ww-Aaa-Tttt")]
        [TestCase("", "")]
        [TestCase("3", "")]
        public void GivenAnInputWhenMumblingIsCalledThenItReturnsExpectedOutput(string testInput, string expectedOutput)
        {
            var result = MumblingUsings.Mumbling(testInput);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void GivenAnInputWhenMumblingIsCalledThenTheResultContainsHyphens()
        {
            var testInput = "abcd";

            var result = MumblingUsings.Mumbling(testInput);

            Assert.That(result.Contains("-"), Is.True);
        }

        [Test]
        public void GivenAnInputWhenMumblingIsCalledThenTheResultContainsCapitalisedLetters()
        {
            var testInput = "abcd";

            var result = MumblingUsings.Mumbling(testInput);

            Assert.That(result.Contains("A"), Is.True);
            Assert.That(result.Contains("B"), Is.True);
            Assert.That(result.Contains("C"), Is.True);
            Assert.That(result.Contains("D"), Is.True);
        }

        [Test]
        public void GivenAnInputWhenMumblingIsCalledThenTheResultContainsDuplicatesOfEachLetter()
        {
            var testInput = "abcd";

            var result = MumblingUsings.Mumbling(testInput);

            Assert.That(result, Is.EqualTo("A-Bb-Ccc-Dddd"));
        }
    }
}