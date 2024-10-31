namespace Library;

public class HijoMayorVisitor: IVisitor<Person>
{
    public int MaxAge {get; private set;} = 0;
    public void Visit(Node<Person> node)
    {
        //Al poner node.Children.Count == 0 se fija si el nodo es hoja (es decir, no tiene hijos.)
        if (node.Children.Count == 0 && node.Number.Age > MaxAge)
        {
            MaxAge = node.Number.Age;
        }

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
        
    }
}