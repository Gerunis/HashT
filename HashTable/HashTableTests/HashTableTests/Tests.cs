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
                dict.PutPair(i, i*10);
            }
            for (var i = 0; i < 3; i++)
            {
                Assert.AreEqual(i*10, dict.GetValueByKey(i));
            }
        }
        
        [Test]
        public void SameKeyTest()
        {
            var dict = new HashTable.HashTable(3);
            dict.PutPair(1,10);
            dict.PutPair(1,15);
            Assert.AreEqual(15, dict.GetValueByKey(1));
        }
        
        [Test]
        public void OneInTenThousandsTest()
        {
            var dict = new HashTable.HashTable(10000);
            for (var i = 0; i < 10000; i++)
            {
                dict.PutPair((i*1000).ToString(), i);
            }
            Assert.AreEqual(20, dict.GetValueByKey("20000"));
        }
        
        [Test]
        public void ThousandInTenThousandsTest()
        {
            var dict = new HashTable.HashTable(10000);
            for (var i = 0; i < 10000; i++)
            {
                dict.PutPair((i*1000).ToString(), i);
            }

            for (var i = 0; i < 1000; i++)
                Assert.Null(dict.GetValueByKey(i));
        }
    }
}