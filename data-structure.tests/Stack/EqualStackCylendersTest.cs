using data_structure.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.tests.Stack
{
    [TestClass]
    public class EqualStackCylendersTest
    {
        [TestMethod]
        public void Test_EqualStackCylender()
        {
            List<int> h1 = new List<int>() { 3, 2, 1, 1, 1 };
            List<int> h2 = new List<int>() { 4, 3, 2 };
            List<int> h3 = new List<int>() { 1, 1, 4, 1 };

            int result = EqualStackCylenders.equalStack(h1, h2, h3);
        }
    }
}
