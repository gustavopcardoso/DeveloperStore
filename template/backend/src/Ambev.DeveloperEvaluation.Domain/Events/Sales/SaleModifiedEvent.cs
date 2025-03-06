using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;

namespace Ambev.DeveloperEvaluation.Domain.Events.Sales
{
    public class SaleModifiedEvent
    {
        public Sale sale { get; private set; }

        public SaleModifiedEvent(Sale sale)
        {
            this.sale = sale;
        }
    }
}
