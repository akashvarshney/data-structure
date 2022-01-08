namespace data_structure.SinglyLinkedList
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; private set; }

        /// <summary>
        /// Adding value to last of linked list 
        /// Making sure compexity is O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddLast(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                Tail = this.Head;
            }
            else
            {
                // 10-->12-->23-->65-->
                Node newNode = new Node(val);
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        /// <summary>
        /// Adding @ first Place 
        /// Time Complexity O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddFirst(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                Tail = this.Head;
            }
            else
            {
                Node node = new Node(val);
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        /// <summary>
        /// Insert at index 
        /// Time complexity id O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void InsertAt(int index, int val)
        {
            if (index >= Count)
            {
                Console.WriteLine("Index out of range");
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(val);
                }
                else if (index == Count - 1)
                {
                    AddLast(val);
                }
                else
                {
                    Node Pre = Head;

                    //Need to travese the linked List till index -1
                    for (int i = 0; i < index - 1; i++)
                    {
                        Pre = Pre.Next;
                    }
                    Node After = Pre.Next;
                    Node newNode = new Node(val);
                    Pre.Next = newNode;
                    newNode.Next = After;

                    Count++;
                }
            }
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("Emptry Linked List");
            }
            else
            {
                Node temp = Head.Next;
                Head = temp;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Node pre = Head;
                Node temp = Head.Next;
                while (temp.Next != null)
                {
                    pre = pre.Next;
                }
                pre.Next = null;
                Tail = pre;
                Count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                Console.WriteLine("Index out of range");
            }
            else
            {
                if (index == 0)
                {
                    RemoveFirst();
                }
                else if (index == Count - 1)
                {
                    RemoveLast();
                }
                else
                {
                    Node Pre = Head;
                    Node After = Pre.Next;
                    //Need to travese the linked List till index -1
                    for (int i = 0; i < index - 1; i++)
                    {
                        Pre = Pre.Next;
                        After = After.Next;
                    }

                    Pre.Next = After;
                    Count--;
                }
            }
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
            Next = null;
        }
    }

}