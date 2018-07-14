using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Dependencies;

namespace UnitTests
{
    [TestClass]
    public class UT_LinkedNode
    {
        public void CheckDettach( LinkedNode<int> node)
        {
            var prev = node.Previous;
            var next = node.Next;
            node.Dettach();
            if(prev != null)
                Assert.IsTrue(prev.Next==next);

            CheckIfLinked(prev, next);
            Assert.IsTrue(node.HasNoNeighbors);
        }

        public void CheckIfLinked(LinkedNode<int> prev, LinkedNode<int> next)
        {
            if(prev != null)
                Assert.IsTrue(prev.Next == next);
            if(next != null)
                Assert.IsTrue(next.Previous == prev);
        }

        public void CheckAttachAfter(LinkedNode<int> node, LinkedNode<int> after)
        {
            var prev_node = node.Previous;
            var next_node = node.Next;
            var prev_after = after.Previous;
            var next_after = after.Next;
            after.AttachAfter(node);

            CheckIfLinked(prev_after, after);
            CheckIfLinked(after, node);
            CheckIfLinked(node, next_after);
            CheckIfLinked(prev_node, next_node);
        }

        [TestMethod]
        public void Test_Dettach()
        {
            var n1 = new LinkedNode<int>(1);
            var n2 = new LinkedNode<int>(2);
            var n3 = new LinkedNode<int>(3);
            var n4 = new LinkedNode<int>(4);
            var n5 = new LinkedNode<int>(5);
            n1.Next = n2; n2.Previous = n1;
            n2.Next = n3; n3.Previous = n2;
            n3.Next = n4; n4.Previous = n3;
            n4.Next = n5; n5.Previous = n4;
            CheckDettach(n2);
            CheckDettach(n4);
            CheckDettach(n5);
            CheckDettach(n3);
            CheckDettach(n1);
        }

        [TestMethod]
        public void Test_Attach()
        {
            var n1 = new LinkedNode<int>(1);
            var n2 = new LinkedNode<int>(2);
            var n3 = new LinkedNode<int>(3);
            n1.Next = n2; n2.Previous = n1;
            n2.Next = n3; n3.Previous = n2;

            var n4 = new LinkedNode<int>(4);
            var n5 = new LinkedNode<int>(5);
            var n6 = new LinkedNode<int>(6);
            var n7 = new LinkedNode<int>(7);
            var n8 = new LinkedNode<int>(8);
            CheckAttachAfter(n4,n2);
            CheckAttachAfter(n5,n1);
            CheckAttachAfter(n6,n3);
            CheckAttachAfter(n7,n6);
            CheckAttachAfter(n8,n6);
        }
    }
}
