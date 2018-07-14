using CloneBehave;
using GA_Travelling_Salesman.Dependencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Dependencies;

namespace GA_Travelling_Salesman
{
    public class CircularPath
    {
        List<LinkedNode<Point>> nodes;
        Decimal distance = 0;

        public Decimal Distance { get => distance; private set => distance = value; }
        public Decimal Distance2 {
            get
            {
                Decimal distance = 0;
                var begin = AnyNode;
                var iterNode = begin;
                do
                {
                    distance += iterNode.Value.DistanceTo(iterNode.Previous.Value);
                    iterNode = iterNode.Next;
                } while (iterNode != begin);
                return distance;
            }
            private set => distance = value;

        }
        public int Count { get => Nodes.Count; }
        List<LinkedNode<Point>> Nodes { get => nodes; set => nodes = value; }
        LinkedNode<Point> AnyNode { get => nodes.Last(); }

        public CircularPath(ICollection<Point> points)
        {
            this.Nodes = new List<LinkedNode<Point>>(points.Count);
            foreach (var point in points)
                InsertAfter(point);
        }

        void InsertAfter(Point point, LinkedNode<Point> after=null)
        {
            var newNode = new LinkedNode<Point>(point);
            if (Count == 0)
                newNode.Previous = newNode.Next = newNode;
            else
                MoveAfter(newNode, AnyNode);
            Nodes.Add(newNode);
        }

        void MoveAfter(LinkedNode<Point> node, LinkedNode<Point> after)
        {
            DettachNode(node);
            AttachAfter(node, after);
        }

        void DettachNode(LinkedNode<Point> node)
        {
            if (node.HasFullNeighbors)
            {
                var next_node = node.Next;
                var prev_node = node.Previous;
                Distance -= node.Value.DistanceTo(prev_node.Value);
                Distance -= node.Value.DistanceTo(next_node.Value);
                Distance += prev_node.Value.DistanceTo(next_node.Value);
                node.Dettach();
            }
        }
        void AttachAfter(LinkedNode<Point> node, LinkedNode<Point> after)
        {
            var next_after = after.Next;
            var prev_after = after.Previous;
            Distance -= after.Value.DistanceTo(next_after.Value);
            Distance += after.Value.DistanceTo(node.Value);
            Distance += node.Value.DistanceTo(next_after.Value);
            after.AttachAfter(node);
        }

        public List<Point> ToList()
        {
            var list = new List<Point>(Count);
            var begin = AnyNode;
            var iterNode = begin;
            do
            {
                list.Add(iterNode.Value);
                iterNode = iterNode.Next;
            } while (iterNode != begin);
            return list;
        }

        public Point[] ToArray()
        {
            var array = new Point[Count];
            int i = 0;
            var begin = AnyNode;
            var iterNode = begin;
            do
            {
                array[i++] = iterNode.Value;
                iterNode = iterNode.Next;
            } while (iterNode != begin);
            return array;
        }

        public void MoveDestinationRandomly(Random random, int timesToMove = 1)
        {
            if (Count < 4) return;
            while (timesToMove-- > 0)
            {
                var randomNode = Nodes[random.Next(0, Count)];
                var randomNodeAfter = randomNode;
                while (randomNode == (randomNodeAfter = Nodes[random.Next(0, Count)])) ;
                MoveAfter(randomNode, randomNodeAfter);
            }
        }

        public void SwapDestinationRandomly(Random random, int timesToMove = 1)
        {
            if (Count < 4) return;
            while (timesToMove-- > 0)
            {
                var randomNode1 = Nodes[random.Next(0, Count)];
                var randomNode2 = randomNode1;
                while (randomNode1 == (randomNode2 = Nodes[random.Next(0, Count)]) || 
                        randomNode1.Previous == randomNode2 || 
                        randomNode2.Previous == randomNode1 );
                var before1 = randomNode1;
                var before2 = randomNode2;
                MoveAfter(randomNode2, before1);
                MoveAfter(randomNode1, before2);
            }
        }

        public CircularPath Clone()
        {
            var orderedPoints = new List<Point>(Count);
            var begin = AnyNode;
            var iterNode = begin;
            do
            {
                orderedPoints.Add(iterNode.Value);
                iterNode = iterNode.Next;
            } while (iterNode != begin);
            return new CircularPath(orderedPoints);
        }

        public List<Point> SliceRandom(Random random, int length = 0)
        {
            if (length == 0)
                length = random.Next(1, Count + 1);
            var slice = new List<Point>(length);
            var begin = nodes[random.Next(0, Count)];
            var iterNode = begin;
            while (length-- > 0)
            {
                slice.Add(iterNode.Value);
                iterNode = iterNode.Next;
            };
            return slice;
        }

        public override string ToString()
        {
            var str = "[ ";
            var begin = AnyNode.Next;
            var iterNode = begin;
            do
            {
                str += iterNode.Value + ", ";
                iterNode = iterNode.Next;
            } while (iterNode != begin); 
            str += "];\n";
            str += "Distance = " + this.distance + "; Count = " + this.Count;
            return str;
        }

        bool AllFullNeighbors()
        {
            var begin = AnyNode.Next;
            var iterNode = begin;
            do
            {
                if (!iterNode.HasFullNeighbors) return false;
                iterNode = iterNode.Next;
            } while (iterNode != begin);
            return true;
        }
        
    }
}
