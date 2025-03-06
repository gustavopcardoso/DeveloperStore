using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class GetSaleQuery : IRequest<GetSaleResult>
    {
        public Guid Id { get; set; }
    }
}
