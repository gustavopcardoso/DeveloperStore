using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        public string CustomerName { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public List<CreateSaleItemCommand> SaleItems { get; set; } = new List<CreateSaleItemCommand>();
    }

    public class CreateSaleItemCommand
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
