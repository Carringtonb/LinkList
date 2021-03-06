using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NodeClassHasValueProperty()
        {
    
            Node node = new Node();

    
            Assert.IsType<int>(node.Value);
        }

        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;

            Assert.Equal(10, node.Value);
        }

        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);
        }

        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        [Fact]
        public void NextProperyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);

        }

        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.Head.Value);
        }

        [Fact]
        public void CanFindNodeWithValueInLL()
        {
    
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(30);

            Assert.True(exists);
        }

        [Fact]
        public void CannotFindNodewithValueinLL()
        {
     
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

  
            bool exists = ll.Includes(32);

            Assert.False(exists);
        }

        [Fact]
        public void CanFindHeadValueSuccessfullyInLL()
        {
      
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            bool exists = ll.Includes(42);
            Assert.True(exists);

        }

        [Fact]
        public void CanFindLastNodeValueInLL()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

  
            bool exists = ll.Includes(10);
            Assert.True(exists);
        }

        [Fact]
        public void CanConvertLinkListToString()
        {
       
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

     
            string carrington = ll.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL";
            // Assert
            Assert.Equal(expected, carrington);

        }
    }
}
