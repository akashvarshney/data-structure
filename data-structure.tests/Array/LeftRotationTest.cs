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
    public class LeftRotationTest
    {
        [TestMethod]
        public void LeftRotation_Test()
        {
            //arrange 
            List<int> list = new List<int>() {1,2,3,4,5 ,6};
            int b = 4; 

            LeftRotation.Rotate(list, b);

        }
    }
}
