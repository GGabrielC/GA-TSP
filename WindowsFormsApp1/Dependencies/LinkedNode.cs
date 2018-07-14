using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dependencies
{
    public class LinkedNode<Type>
    {
        Type value;
        LinkedNode<Type> next;
        LinkedNode<Type> previous;
        
        public Type Value { get => value; private set => this.value = value; }
        public LinkedNode<Type> Next { get => next; set => next = value; }
        public LinkedNode<Type> Previous { get => previous; set => previous = value; }
        public bool HasFullNeighbors { get => Next!=null && Previous!=null; }
        public bool HasNoNeighbors { get => Next == null && Previous == null; }

        public LinkedNode(Type value) => Value = value;

        public void AttachAfter(LinkedNode<Type> node)
        {
            if (node == null || node == this || node.Next == this)
                return;

            node.Dettach();
            node.Next = this.Next;
            node.Previous = this;
            if(this.next!=null)
                this.Next.Previous = node;
            this.Next = node;
        }

        public void Dettach()
        {
            if (this.Previous != null)
                this.Previous.Next = this.Next;
            if (this.Next != null)
                this.Next.Previous = this.Previous;
            this.Next = this.Previous = null;
        }
        
    }
}
