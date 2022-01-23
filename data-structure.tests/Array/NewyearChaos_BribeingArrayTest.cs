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
    public class NewyearChaos_BribeingArrayTest
    {
        [TestMethod]
        public void Test_LeftRotationArray()
        {
            int rotation = 3;
            List<int> list = new List<int>() { 2,5,1,3,4};
             NewyearChaos_BribeingArray.minimumBribes2(list);
        }
    }
}
