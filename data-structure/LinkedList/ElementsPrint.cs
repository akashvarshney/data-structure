using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace data_structure.LinkedList
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }
    public class ElementsPrint
    {
        public static void Print(SinglyLinkedListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;

            }
        }
    }
}
