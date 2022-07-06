namespace CqrsSample.CQRS.Commands.Response;

public class CreateProductCommandResponse : BaseResponse
{
	public Guid ProductId { get; set; }
}