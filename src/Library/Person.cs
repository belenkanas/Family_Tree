
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library;

public class Person
{
    public string Name {get; set;}
    public int Edad{get; set;}

    public Person (string name, int edad)
    {
       this.Name = name;
       this.Edad = edad;
    } 
}