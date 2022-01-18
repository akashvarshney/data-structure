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
    public class GameOfTwoStackTest
    {
        [TestMethod]
        public void TestGameOfTwoStack()
        {
            // arrange 
            int maxSum = 10;
            List<int> a = new List<int>() { 4, 2, 4, 6, 1 };
            List<int> b = new List<int>() { 2, 1, 8, 5 };
            var result = GameOfTwoStack.TwoStackOtherways(maxSum, a, b);

        }

    }
}
