namespace Library;
public class NombreLargoVisitor : Visitor<Person>
{
    public string NombreLargo {get; private set;} = string.Empty;
    public override void Visit(Node<Person> node)
    {
        if (node.Data.Name.Length > NombreLargo.Length)
        {
            NombreLargo = node.Data.Name;
        }

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}