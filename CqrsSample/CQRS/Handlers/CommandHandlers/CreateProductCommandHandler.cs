using CqrsSample.CQRS.Commands.Request;
using CqrsSample.CQRS.Commands.Response;
using MediatR;

namespace CqrsSample.CQRS.Handlers.CommandHandlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
	public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
	{
		return new CreateProductCommandResponse { IsSuccess = true, ProductId = Guid.NewGuid() };
	}
}