using data_structure.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.tests
{
    [TestClass]
    public class QueueUsingLLTest
    {

        [TestMethod]
        public void Test_Enqueue_QueueUsingLL()
        {

            QueueUsingLL queueUsingLL = new QueueUsingLL();
            queueUsingLL.EnQueue(1);
            queueUsingLL.EnQueue(2);
            queueUsingLL.EnQueue(3);
            queueUsingLL.EnQueue(4);
            queueUsingLL.EnQueue(5);

            Assert.AreEqual(queueUsingLL.First.Value, 1);
            Assert.AreEqual(queueUsingLL.Last.Value, 5);

        }

        [TestMethod]
        public void Test_Dequeue_QueueUsingLL()
        {

            QueueUsingLL queueUsingLL = new QueueUsingLL();
            queueUsingLL.EnQueue(1);
            queueUsingLL.EnQueue(2);
            queueUsingLL.EnQueue(3);
            queueUsingLL.EnQueue(4);
            queueUsingLL.EnQueue(5);
            queueUsingLL.Dequeue();
            Assert.AreEqual(queueUsingLL.First.Value, 4);
            Assert.AreEqual(queueUsingLL.Last.Value, 1);


        }

        [TestMethod]
        public void Test_Peek_QueueUsingLL()
        {
            QueueUsingLL queueUsingLL = new QueueUsingLL();
            queueUsingLL.EnQueue(1);
            queueUsingLL.EnQueue(2);
            var result = queueUsingLL.Peek();
            Assert.AreEqual(result, 1);

        }
    }
}
