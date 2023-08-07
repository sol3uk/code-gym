using System.Text;
using NUnit.Framework;

namespace TestProject1;

public class MakingChangeTests
{
    [TestFixture]
    public class MakingChange
    {
        [Test]
        public void Given3CentsThenTheCorrectPermutationsAreReturned()
        {
            var result = MakingChangeUsings.GetChange(3);

            var expectedOutput = new List<string>()
            {
                "2 1",
                "1 1 1"
            };
            
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}