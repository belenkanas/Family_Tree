namespace Library;

public class HijoMayorVisitor: IVisitor<Person>
{
    public int EdadMax {get; private set;} = 0;
    public void Visit(Node<Person> node)
    {
        if (node.Children.Count == 0 && node.Number.Age > EdadMax)
        {
            EdadMax = node.Number.Age;
        }

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}