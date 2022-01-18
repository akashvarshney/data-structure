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
    public class LargestRectangleTest
    {
        [TestMethod]
        public void GetLargestRectangle()
        {
            //aggarnge 
            List<int> list = new List<int>() { 5,4,3,3,5,4,2,5,0,2,5};
            //List<int> list1 = new List<int>() { 11, 11, 10, 10, 10 };
            var result = LargestRactangle.GetArea(list);
        }
    }
}
