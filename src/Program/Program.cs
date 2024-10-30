using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n4 = new Node<int>(4);
            Node<int> n5 = new Node<int>(5);
            Node<int> n6 = new Node<int>(6);
            Node<int> n7 = new Node<int>(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
<<<<<<< HEAD

            //Se crean los nodos del arbol genealógico
            Node<Person> hijo = new Node<Person>(new Person("Hijo", 10));
            Node<Person> hermano = new Node<Person>(new Person("Hermano", 19));
            Node<Person> padre = new Node<Person>(new Person("Padre", 45));
            Node<Person> madre = new Node<Person>(new Person("Madre", 45));
            Node<Person> tio = new Node<Person>(new Person("Tio", 39));
            Node<Person> abuelo = new Node<Person>(new Person("Abuelo", 80));
            Node<Person> abuela = new Node<Person>(new Person("Abuela", 75));

            //Se construye el arbol.
            abuelo.AddChildren(padre);
            abuela.AddChildren(padre);
            abuelo.AddChildren(tio);
            padre.AddChildren(hijo);
            madre.AddChildren(hijo);
            padre.AddChildren(hermano);
            madre.AddChildren(hermano);

            
        
        
        
=======
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
            
>>>>>>> 6ef430c141274ae2aa6fefdc7266fe393e1bc1ee
        }
    }
}
