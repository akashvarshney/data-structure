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
    public class HourGlasss2DArrayTest
    {

        [TestMethod]
        public void Test_HourGlass2DArray()
        {
            //arragnge


            List<List<int>> vs = new List<List<int>>()
            {
                new List<int>{1, 1, 1, 0, 0, 0},
                new List<int>{0, 1, 0, 0, 0, 0},
                new List<int>{1, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 2, 4, 4, 0},
                new List<int>{0, 0, 0, 2, 0, 0},
                new List<int>{0, 0, 1, 2, 4, 0}
            };

            HourGlasss2DArray hourGlasss2DArray = new HourGlasss2DArray();
            var sum = HourGlasss2DArray.hourglassSum(vs);
            Console.WriteLine(sum);

        }

        [TestMethod]
        public void Test2_HourGlass2DArray()
        {
            //arragnge


            List<List<int>> vs = new List<List<int>>()
            {
                new List<int>{-1    ,-1     ,0      ,-9     ,-2    ,-2},
                new List<int>{-2    ,-1     ,-6     ,-8     ,-2    ,-5 },
                new List<int>{-1    ,-1     ,-1     ,-2     ,-3    ,-4},
                new List<int>{-1    ,-9     ,-2     ,-4     ,-4    ,-5},
                new List<int>{-1    ,-9     ,-2     ,-4     ,-4    ,-5},
                new List<int>{-1  ,-9     ,- 2    ,- 4    ,- 4   ,- 5 }
            };

            HourGlasss2DArray hourGlasss2DArray = new HourGlasss2DArray();
            var sum = HourGlasss2DArray.hourglassSum(vs);
            Console.WriteLine(sum);

        }
    }
}
