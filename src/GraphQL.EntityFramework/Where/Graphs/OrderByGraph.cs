using GraphQL.Types;

public class OrderByGraph :
    InputObjectGraphType<OrderBy>
{
    public OrderByGraph()
    {
        Field(x => x.Path);
        Field(x => x.Descending, true);
    }
}