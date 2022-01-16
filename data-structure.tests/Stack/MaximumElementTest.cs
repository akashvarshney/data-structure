using data_structure.Arrays;
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
    public class MaximumElementTest
    {
        [TestMethod]
        public void MaximumElement_Test()
        {
            List<string> list = new List<string>() { "1 97", "2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3" };

            MaximumElement.getMax(list);
        }
    }
}
