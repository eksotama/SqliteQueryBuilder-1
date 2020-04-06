using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLiteQueryBuilder.QuerySelect;

namespace QueryBuilderTest
{
    [TestClass]
    public class TestBasicQuery
    {
        [TestMethod]
        public void TestMethod1()
        {
            var basicQuery = new Query("Select");
        }
    }
}
