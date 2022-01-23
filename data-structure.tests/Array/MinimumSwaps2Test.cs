using data_structure.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.tests.Array
{
    [TestClass]
    public class MinimumSwaps2Test
    {
        [TestMethod]
        public void minimumSwap2()
        {
            //arrange 
            List<int> list = new List<int>() { 4, 3, 1, 2 };
            var arr = list.ToArray();
            MinimumSwap2.minimumswaps(arr);
        }
    }
}
