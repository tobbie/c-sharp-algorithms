using System;

using Xunit;
using DataStructures.Trees.Easy;
using Common;
using DataStructures.Trees;
using System.Collections.Generic;

namespace DataStructures.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void ShouldReturnSum()
        {
            //arrange

            var a = new BTNode<int>(3);
            var b = new BTNode<int>(11);
            var c = new BTNode<int>(4);
            var d = new BTNode<int>(4);
            var e = new BTNode<int>(-2);
            var f = new BTNode<int>(1);

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            //act
            var actual = TreeSum.Sum(a);

            //assert
            Assert.Equal(21, actual);

        }

        [Fact]
        public void ShouldIncludeValue()
        {
            var a = new BTNode<char>('a');
            var b = new BTNode<char>('b');
            var c = new BTNode<char>('c');
            var d = new BTNode<char>('d');
            var e = new BTNode<char>('e');
            var f = new BTNode<char>('f');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            var actual = TreeIncludes.HasTarget(a, 'e');
            Assert.True(actual);
        }

        [Fact]
        public void ShouldReturnDFSValues()
        {
            var a = new BTNode<char>('a');
            var b = new BTNode<char>('b');
            var c = new BTNode<char>('c');
            var d = new BTNode<char>('d');
            var e = new BTNode<char>('e');
            var f = new BTNode<char>('f');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            var expected = new List<char> { 'a', 'b', 'd', 'e', 'c', 'f' };

            var actual = BinaryTreeTraversal.DepthFirstSearch(a);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDFSValuesRecursively()
        {
            var a = new BTNode<char>('a');
            var b = new BTNode<char>('b');
            var c = new BTNode<char>('c');
            var d = new BTNode<char>('d');
            var e = new BTNode<char>('e');
            var f = new BTNode<char>('f');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            var expected = new List<char> { 'a', 'b', 'd', 'e', 'c', 'f' };

            var actual = BinaryTreeTraversal.DepthFirstSearchRecursive(a);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ShouldReturnBFSValues()
        {
            var a = new BTNode<char>('a');
            var b = new BTNode<char>('b');
            var c = new BTNode<char>('c');
            var d = new BTNode<char>('d');
            var e = new BTNode<char>('e');
            var f = new BTNode<char>('f');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            var expected = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

            var actual = BinaryTreeTraversal.BreadthFirstSearch(a);
            Assert.Equal(expected, actual);
        }
    }
}
