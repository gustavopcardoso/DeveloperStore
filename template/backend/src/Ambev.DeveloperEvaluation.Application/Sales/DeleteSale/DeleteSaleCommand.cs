using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class DeleteSaleCommand : IRequest<DeleteSaleResult>
    {
        public Guid Id { get; set; }
    }
}
