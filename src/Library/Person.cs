
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library;

public class Person{
   
    private List<Person> people = new List<Person>();
    public string Name {get; set;}
    public int Edad{get; set;}

    public Person (string name, int edad)
    {
        this.Name = name;
        this.Edad = edad;
    } 

    public void AddPerson(Person p)
        {
            this.people.Add(p);
        }
    
}