using System;
using HashTable;
using NUnit.Framework;

namespace HashTableTests
{
    [TestFixture]
    public class Tests
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