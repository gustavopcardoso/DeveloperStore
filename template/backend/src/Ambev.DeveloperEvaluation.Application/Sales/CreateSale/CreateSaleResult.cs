using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleResult
    {
        public Guid Id { get; set; }
        public int SaleNumber { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalSaleAmount { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public List<CreateSaleItemResult> SaleItems { get; set; } = new List<CreateSaleItemResult>();
        public SaleStatus SaleStatus { get; set; }
    }

    public class CreateSaleItemResult
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discounts { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
