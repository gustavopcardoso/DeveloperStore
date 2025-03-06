using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;

namespace Ambev.DeveloperEvaluation.Domain.Events.Sales
{
    public class SaleCreatedEvent
    {
        public Sale Sale { get; private set; }

        public SaleCreatedEvent(Sale sale)
        {
            Sale = sale;
        }
    }
}
