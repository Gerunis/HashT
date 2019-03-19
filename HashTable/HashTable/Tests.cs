using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HashTable
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void SimpleTest()
        {
            var dict = new HashTable(3);
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
