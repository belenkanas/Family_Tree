namespace Library;

public class SumarEdadesVisitor: IVisitor<Person>
{
    private int sumaEdad = 0;

    public void Visit(Node<Person> node)
    {
        if (node != null && node.Number != null)
        {
            sumaEdad += node.Number.Age;
        }
        
    }

    public int Sum 
    {
        get 
        { 
            return sumaEdad;
        }
    }

}
