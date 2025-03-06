using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Aggregates.Sale
{
    public class Sale : BaseEntity
    {
        public string CustomerName { get; set; } = string.Empty;
        public int SaleNumber { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public List<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
        public SaleStatus SaleStatus { get; set; }

        public Sale()
        {
            SaleStatus = SaleStatus.NotCancelled;
        }        

        public void Cancel()
        {
            if (SaleStatus == SaleStatus.Cancelled)
                throw new DomainException("Sale already cancelled");
            SaleStatus = SaleStatus.Cancelled;
        }

        public void CalculateDiscounts() => SaleItems.ForEach(p => p.CalculateDiscounts(p.UnitPrice, p.Quantity));

        public void CheckQuantity() => SaleItems.ForEach(p => p.CheckQuantity());

        public void CalculateTotalAmount() => TotalSaleAmount = SaleItems.Sum(x => x.TotalAmount);

        public void CheckDuplicates()
        {
            var duplicates = SaleItems.GroupBy(x => x.Id)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            if (duplicates.Any())
                throw new DomainException($"Duplicate products in the list");
        }
    }
}
