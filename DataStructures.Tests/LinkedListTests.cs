using DataStructures.LinkedLists.Hard;
using DataStructures.LinkedLists.Medium;
using Xunit;
using DataStructures.LinkedLists.VeryHard;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void ShouldSetHead()
        {
            //Arrange

            var node = new Node(1);
            var ddList = new DoublyLinkedList();

            //Act

            ddList.SetHead(node);


            //Assert
            Assert.Equal(ddList.Head.Value, node.Value);

        }

        [Fact]
        public void ShouldSetHeadAndTail()
        {
            //Arrange

            var node = new Node(1);
            var ddList = new DoublyLinkedList();

            //Act

            ddList.SetHead(node);


            //Assert
            Assert.Equal(node, ddList.Head);
            Assert.Equal(node, ddList.Tail);
        }

        [Fact]
        public void ShouldSetTail()
        {
            //Arrange

            var node = new Node(1);
            var node2 = new Node(4);
            var ddList = new DoublyLinkedList();

            //Act

            ddList.SetTail(node);
            ddList.SetTail(node2);


            //Assert
            
            Assert.Equal(node2, ddList.Tail);
        }

        [Fact]
        public void ShouldContainValue() {
            //Arrange
            var linkedList = new DoublyLinkedList();

            //Act
            for (int index = 1; index <= 4; index++)
            {
                var node = new Node(index);
                linkedList.SetTail(node);
            }

            //Assert
            Assert.True(linkedList.ContainsNodeWithValue(1));
            Assert.True(linkedList.ContainsNodeWithValue(2));
            Assert.True(linkedList.ContainsNodeWithValue(3));
            Assert.True(linkedList.ContainsNodeWithValue(4));
        }

        [Fact]
        public void ShouldNotContainValue()
        {
            //Arrange
            var linkedList = new DoublyLinkedList();

            //Act
            for (int index = 1; index <= 4; index++)
            {
                var node = new Node(index);
                linkedList.SetTail(node);
            }

            //Assert
            Assert.False(linkedList.ContainsNodeWithValue(5));
            Assert.False(linkedList.ContainsNodeWithValue(6));
            
        }

        [Fact]
        public void ShouldRemoveNode()
        {
            //Arrange
            var linkedList = new DoublyLinkedList();

        
            for (int index = 1; index <= 4; index++)
            {
                var node = new Node(index);
                linkedList.SetTail(node);
            }

            //Act
            var nodeToRemove = linkedList.FindNode(2);
            linkedList.Remove(nodeToRemove);
            //Assert
            Assert.False(linkedList.ContainsNodeWithValue(2));
            

        }


        [Fact]
        public void ShouldFindNode()
        {
            //Arrange
            var linkedList = new DoublyLinkedList();

            //Act
            for (int index = 1; index <= 4; index++)
            {
                var node = new Node(index);
                linkedList.SetTail(node);
            }

            var actual = linkedList.FindNode(3);
            var actual2 = linkedList.FindNode(4);

            //Assert
            Assert.Equal<int>(3, actual.Value);
            Assert.Equal<int>(4, actual2.Value);
        }

        [Fact]
        public void ShouldNotFindNode()
        {
            //Arrange
            var linkedList = new DoublyLinkedList();

            //Act
            for (int index = 1; index <= 4; index++)
            {
                var node = new Node(index);
                linkedList.SetTail(node);
            }

            var actual = linkedList.FindNode(5);
            var actual2 = linkedList.FindNode(6);

            //Assert
            Assert.Null(actual);
            Assert.Null(actual2);
        }

        [Fact]
        public void ShouldRotateList()
        {
            //arrange
            var list = new SinglyLinkedList();
            list.Add(new ListNode(0));
            list.Add(new ListNode(1));
            list.Add(new ListNode(2));
            list.Add(new ListNode(3));
            list.Add(new ListNode(4));
            list.Add(new ListNode(5));
            //act

            var actual = RotateLinkedList.Rotate(list.Head, -2);
            
            //assert
            Assert.Equal(2, actual.Value);
          
        }

        [Fact]
        public void ShouldTestLRUCache()
        {
            //arrange
            var sut = new LRUCache(3);
            sut.InsertKeyValuePair("b", 2);
            sut.InsertKeyValuePair("a", 1);
            sut.InsertKeyValuePair("c", 3);
            //act

            var actual1 = sut.GetMostRecentKey();
            var actual2 = sut.GetValueFromKey("a").value;
            var actual3 = sut.GetMostRecentKey();
            sut.InsertKeyValuePair("d", 4);
            var actual4 = sut.GetValueFromKey("b");
            sut.InsertKeyValuePair("a", 5);
            var actual5 = sut.GetValueFromKey("a");
            //assert

            Assert.Equal("c", actual1);
            Assert.Equal(1, actual2);
            Assert.Equal("a", actual3);
            Assert.Null(actual4);
            Assert.Equal(5, actual5.value);


        }


    }
}
