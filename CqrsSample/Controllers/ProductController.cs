using CqrsSample.CQRS.Commands.Request;
using CqrsSample.CQRS.Commands.Response;
using CqrsSample.CQRS.Queries.Request;
using CqrsSample.CQRS.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
	private readonly IMediator _mediator;

	public ProductController(IMediator mediator)
	{
		_mediator = mediator;
	}


	[HttpGet("/products")]
	public async Task<List<GetAllProductQueryResponse>> GetAllProducts()
	{
		var response = await _mediator.Send(new GetAllProductQueryRequest());
		return response;
	}

	[HttpPost("/products")]
	public async Task<CreateProductCommandResponse> CreateProduct([FromBody] CreateProductCommandRequest request)
	{
		var response = await _mediator.Send(request);
		return response;
	}
}