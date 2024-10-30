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

            //Se crean los nodos del arbol genealógico
            Node<Person> hijo = new Node<Person>(new Person("Ana", 10));
            Node<Person> hermano = new Node<Person>(new Person("Pedro", 19));
            Node<Person> padre = new Node<Person>(new Person("Nicolas", 45));
            Node<Person> madre = new Node<Person>(new Person("Belén", 45));
            Node<Person> tio = new Node<Person>(new Person("Jorge", 39));
            Node<Person> abuelo = new Node<Person>(new Person("Matías", 80));
            Node<Person> abuela = new Node<Person>(new Person("María", 75));

            //Se construye el arbol.
            abuelo.AddChildren(padre);
            abuela.AddChildren(padre);
            abuelo.AddChildren(tio);
            padre.AddChildren(hijo);
            madre.AddChildren(hijo);
            padre.AddChildren(hermano);
            madre.AddChildren(hermano);

            SumarEdadesVisitor visitor = new SumarEdadesVisitor();
            abuelo.Accept(visitor);
            Console.WriteLine($"Edad total: {visitor.Sum}");

            HijoMayorVisitor hijoMayor = new HijoMayorVisitor();
            abuelo.Accept(hijoMayor);
            Console.WriteLine($"Edad del hijo mayor: {hijoMayor.EdadMax}");

            NombreLargoVisitor nombreLargo = new NombreLargoVisitor();
            abuelo.Accept(nombreLargo);
            Console.WriteLine($"Nombre más largo de la familia: {nombreLargo.NombreLargo}");
        }
    }
}
