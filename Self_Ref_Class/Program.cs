using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Ref_Class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ListNode
    {
        public object Data { get; set; }
        public ListNode Next { get; set; }
        public ListNode(object dataVal) : this(dataVal, null) { }
        
        public ListNode(object dataVal, ListNode nextNode)
        {
            Data = dataVal;
            Next = nextNode;
        }

    }
    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name;
        public List() : this("list") { }
        public List(string name)
        {
            this.name = name;
            firstNode = null;
            lastNode = null;
        }
        public void InsertToFront(object insertedItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertedItem);
            }
            else
            {
                firstNode = new ListNode(insertedItem, firstNode);
            }
        }
        public object RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            object removedItem = firstNode.Data;
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }
            return removedItem;
        }
        public bool IsEmpty()
        {
            return firstNode == null;
        }
        public class EmptyListException : Exception
        {
            public EmptyListException() : base("This list is empty") { }
            public EmptyListException(string name) : base("The " + name + " is empty.") { }
        }
    }
    
}
