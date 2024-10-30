using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> where T: new()
    {
        private int number;
        private List<T> children = new List<T>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<T> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public static int Edad { get; internal set; }

        public Node()
        {
            
        }

        public void AddChildren(T n)
        {
            this.children.Add(n);
        }

        internal void Accept(HijoMayorVisitor hijoMayorVisitor)
        {
            throw new NotImplementedException();
        }

        internal void Accept(NombreLargoVisitor nombreLargoVisitor)
        {
            throw new NotImplementedException();
        }
    }
}
