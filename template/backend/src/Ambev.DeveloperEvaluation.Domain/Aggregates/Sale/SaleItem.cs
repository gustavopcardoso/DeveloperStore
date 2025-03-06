using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Aggregates.Sale
{
    public class SaleItem : BaseEntity
    {
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discounts { get; set; }
        public decimal TotalAmount => UnitPrice * Quantity - Discounts;

        public SaleItem()
        {
        }

        public void CalculateDiscounts(decimal unitPrice, int quantity)
        {
            if (quantity >= 10 && quantity <= 20) 
                Discounts = unitPrice * quantity * 0.2m;

            else if (quantity >= 4)
                Discounts = unitPrice * quantity * 0.1m;
        }

        public void CheckQuantity()
        {
            if (Quantity > 20)
                throw new DomainException($"{ProductName}: Quantity cannot be greater than 20");
        }
    }
}
