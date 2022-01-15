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
    public class Left_RotationArrayTest
    {
        [TestMethod]
        public void Test_LeftRotationArray()
        {
            int rotation = 3;
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           var arry = LeftRotationArray.rotateLeft(rotation,list);
        }
    }
}
