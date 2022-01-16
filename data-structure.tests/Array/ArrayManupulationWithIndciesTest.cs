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
            List<List<long>> list = new List<List<long>>() {
                new List<long> { 1, 2, 100 },
                new List<long> { 2, 5, 100 },
                new List<long> { 3, 4, 100 }
            };

            long result = ArrayManupulationWithIndcies.ArrayManupulatioBetter(arrayLength, list);


        }
    }
}
