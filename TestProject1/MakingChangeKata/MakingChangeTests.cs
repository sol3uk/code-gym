using System.Text;
using NUnit.Framework;

namespace TestProject1;

public class MakingChangeTests
{
    [TestFixture]
    public class MakingChange
    {
        [Test]
        public void Given6CentsThenTheCorrectPermutationsAreReturned()
        {
            var result = MakingChangeUsings.GetChange(6);

            var expectedOutput = new List<string>()
            {
                "1 1 1 1 1 1",
                "5 1",
            };
            
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}