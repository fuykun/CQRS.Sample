namespace CqrsSample.CQRS.Queries.Response;

public class GetAllProductQueryResponse
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public int Quantity { get; set; }
}