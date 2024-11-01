﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node<int> n1 = new Node<int>(1);
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
            */

            // visitar el árbol aquí

            
            //Se crean los nodos del arbol genealógico
            Node<Person> abuelo = new Node<Person>(new Person("Matías", 80));
            Node<Person> padre = new Node<Person>(new Person("Nicolas", 45));
            Node<Person> tio = new Node<Person>(new Person("Jorge", 46));
            Node<Person> hijo = new Node<Person>(new Person("Ana", 10));
            Node<Person> hermano = new Node<Person>(new Person("Pedro", 19));
            Node<Person> primo = new Node<Person>(new Person("Martin", 25));
            Node<Person> prima = new Node<Person>(new Person("Susana", 15));
            
            

            //Se construye el arbol.
            abuelo.AddChildren(padre);
            abuelo.AddChildren(tio);
            padre.AddChildren(hijo);
            padre.AddChildren(hermano);
            tio.AddChildren(primo);
            tio.AddChildren(prima);

            //Suma las edades de todos los participantes del árbol. Tiene que dar 240
            SumarEdadesVisitor sumarVisitor = new SumarEdadesVisitor();
            abuelo.Accept(sumarVisitor);
            Console.WriteLine($"Edad total: {sumarVisitor.Sum}");

            //Retorna a la persona que no tiene hijos y tiene la edad mayor. En este caso retorna la edad del primo hermano mayor (26).
            HijoMayorVisitor hijoMayor = new HijoMayorVisitor();
            abuelo.Accept(hijoMayor);
            Console.WriteLine($"Edad del hijo mayor: {hijoMayor.MaxAge}");

           
            //Retorna el nombre más largo entre todos los integrantes. En este caso es Nicolás.
            NombreLargoVisitor nombreLargo = new NombreLargoVisitor();
            abuelo.Accept(nombreLargo);
            Console.WriteLine($"Nombre más largo de la familia: {nombreLargo.NombreLargo}");
        }
    }
}
