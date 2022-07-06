using CqrsSample.CQRS.Queries.Request;
using CqrsSample.CQRS.Queries.Response;
using MediatR;

namespace CqrsSample.CQRS.Handlers.QueryHandlers;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
{
	public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
	{
		var response = new List<GetAllProductQueryResponse> { new() { Id = Guid.NewGuid(), Name = "Product 1" } };
		return response;
	}
}