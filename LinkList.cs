using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Linklist
    {
        public Node Head { get; set; }
        private Node Current { get; set; }


        // insert method
        public void Insert(int value)
        {
            // instantiate a new Node 
            Node node = new Node();
            // set value to the inputted data
            node.Value = value;
            // set next to head
            node.Next = Head;

            //set that(new node) as the head
            Head = node;
        }

        /// <summary>
        /// Traverses the link list searching for a value by checking every subsequent node for the value 'NULL'
        /// </summary>
        /// <param name="Desired node value"></param>
        /// <returns>Boolean</returns>
        public bool Includes(int value)
        {
            // set c = h
            Current = Head;

            while (Current != null)
            {
                // check if value is equal
                if (Current.Value == value)
                {
                    return true;
                }

                // go to next node
                Current = Current.Next;

            }

            return false;
        }
        /// <summary>
        /// Stringifies every value in the LinkList and returns the value. With the final value always returning "NULL"
        /// </summary>
        /// <returns>A list of values, followed by "NULL"</returns>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            // we are at null at this point
            sb.Append("NULL");
            return sb.ToString();
        }


    }
}