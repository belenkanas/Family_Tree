namespace Library;

public class HijoMayorVisitor : Visitor<Person>
{
    public int EdadMax {get; private set;} = int.MinValue;
    public override void Visit(Node<Person> node)
    {
        if (node.Children.Count == 0 && Node<Person>.Edad > EdadMax)
        {
            EdadMax = node.Data.Edad;
        }

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}