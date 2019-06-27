using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpLibrary;

namespace CsharpLibraryTest
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void TestSwap()
        {
            int x = 1;
            int y = 2;

            Util.Swap(ref x, ref y);
            Assert.AreEqual("2 1", string.Format("{0} {1}", x, y));
        }
    }
}
