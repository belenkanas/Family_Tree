using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library;
public abstract class Abstract
{
    
    public void AddItem(Person p)
    {
        this.people.Add(p);
    }
    
    public void AddItem(Node n)
    {
         this.children.Add(n);
    }
}