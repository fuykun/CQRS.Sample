using CqrsSample.CQRS.Commands.Response;
using MediatR;

namespace CqrsSample.CQRS.Commands.Request;

public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
{
	public string Name { get; set; }
	public int Quantity { get; set; }
}