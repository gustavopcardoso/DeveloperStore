using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class UpdateSaleResult
    {
        public Guid Id { get; set; }
        public int SaleNumber { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalSaleAmount { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public SaleStatus SaleStatus { get; set; }
    }
}
