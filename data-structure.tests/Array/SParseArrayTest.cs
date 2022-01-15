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
    public class SParseArrayTest
    {
        [TestMethod]
        public void Test_SparseTest()
        {
            //arrange 
            List<string> stringlist = new List<string>() { "4", "aba", "baba", "aba", "xzxb", "3", "aba", "xzxb", "ab" };
            List<string> queriesList = new List<string>() { "aba", "xzxb", "ab" };
            List<int> output = SparseArray.MatchingString(stringlist, queriesList);
        }
    }
}
