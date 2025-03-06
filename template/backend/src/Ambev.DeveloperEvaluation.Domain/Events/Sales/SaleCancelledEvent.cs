namespace Ambev.DeveloperEvaluation.Domain.Events.Sales
{
    public class SaleCancelledEvent
    {
        public Guid Id { get; private set; }

        public SaleCancelledEvent(Guid id)
        {
            Id = id;
        }
    }
}
