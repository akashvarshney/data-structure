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
    public class ArrayManupulationWithIndciesTest
    {
        [TestMethod]
        public void ArrayManupulationTest()
        {
            //arrange 
            int arrayLength = 5;
            List<List<int>> list = new List<List<int>>() {
                new List<int> { 1, 2, 100 },
                new List<int> { 2, 5, 100 },
                new List<int> { 3, 4, 100 }
            };

            int result = ArrayManupulationWithIndcies.ArrayManupulation(arrayLength, list);


        }
    }
}
