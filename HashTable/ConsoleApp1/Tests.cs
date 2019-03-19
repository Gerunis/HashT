using NUnit.Framework;
using HashTable;

namespace Tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void SimpleTest()
        {
            var dict = new HashTable.HashTable(3);
            for (var i = 0; i < 3; i++)
            {
                dict.PutPair(i, i);
            }
            for (var i = 0; i < 3; i++)
            {
                Assert.AreEqual(i, dict.GetValueByKey(i));
            }
        }
    }
}
