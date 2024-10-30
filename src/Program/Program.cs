using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Person p1 = new Person("Ana", 40);
            Person p2 = new Person("Belen", 19);
            Person p3 = new Person("Valentina", 19);
            Person p4 = new Person("Jorge", 19);
            Person p5 = new Person("Matias", 19);
            Person p6 = new Person("Sebastian", 37);
            Person p7 = new Person("Angel", 55);
            
            
            p1.AddPerson(p2);
            p1.AddPerson(p3);
            
            p2.AddPerson(p4);
            p2.AddPerson(p5);
            
            p3.AddPerson(p6);
            p3.AddPerson(p7);
            
        }
    }
}
