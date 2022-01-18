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
    public class NextGreaterElementTest
    {
        [TestMethod]
        public void NextGreaterElement_Test()
        {
            var list = NextGreaterElement.FindNextGreaterElement(new List<int> { 1, 3, 5, 82, 3, 8, 3, 0, 5, 3 });

        }
    }
}
