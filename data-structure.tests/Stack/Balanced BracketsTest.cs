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
    public class Balanced_BracketsTest
    {
        [TestMethod]
        public void  BracketsTest()
        {
            var result =   Balanced_Brackets.isBalanced("}][}}(}][))]");
            var result1 = Balanced_Brackets.isBalanced("[](){()}");

            var result2 = Balanced_Brackets.isBalanced("()");
            var result11 = Balanced_Brackets.isBalanced("[](){()}");

            var result114 = Balanced_Brackets.isBalanced("({}([][]))[]()");
            var result122 = Balanced_Brackets.isBalanced("[](){()}");

            var result33 = Balanced_Brackets.isBalanced("{)[](}]}]}))}(())(");
            var result13 = Balanced_Brackets.isBalanced("([[)");
        }
    }
}
