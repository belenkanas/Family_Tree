namespace Library;

public class SumarEdadesVisitor: IVisitor<Person>
{
    private int sumaEdad = 0;

    public int Sum 
    {
        get 
        { 
            return this.sumaEdad;
        }
    }

    public void Visit(Node<Person> node)
    {
        sumaEdad += node.Number.Age;
    }
}
