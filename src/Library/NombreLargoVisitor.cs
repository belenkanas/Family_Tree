namespace Library;
public class NombreLargoVisitor : IVisitor<Person>
{
    public string NombreLargo {get; private set;} = "";
    public void Visit(Node<Person> node)
    {
        if (node.Number.Name.Length > NombreLargo.Length)
        {
            NombreLargo = node.Number.Name;
        }

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }

}