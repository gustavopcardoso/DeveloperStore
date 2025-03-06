using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class ListSaleQuery : IRequest<List<ListSaleResult>>
    {
        public string? CustomerName { get; set; }
        public int Page { get; set; } = 1;
        public int Size { get; set; } = 10;
    }
}
