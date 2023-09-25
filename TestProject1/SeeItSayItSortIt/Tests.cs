using NUnit.Framework;

namespace TestProject1.SeeItSayItSortIt;

public class SortItTests
{
    [TestFixture]
    public class SortIt
    {
        [Test]
        public void SortItTest()
        {
            SortItUsings.SortIt();

            
            Assert.That(true, Is.EqualTo(false) );
        }
    }
}