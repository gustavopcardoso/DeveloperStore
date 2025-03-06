namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface IMessageService
    {
        void Publish<T>(T message, string queueName);
    }
}
