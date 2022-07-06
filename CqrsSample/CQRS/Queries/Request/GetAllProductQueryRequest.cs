using CqrsSample.CQRS.Queries.Response;
using MediatR;

namespace CqrsSample.CQRS.Queries.Request;

public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
{
}