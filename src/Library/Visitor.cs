using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Library;
public abstract class Visitor<T>
{
    public abstract void Visit(Node<T> node);
}