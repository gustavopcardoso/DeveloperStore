using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Messaging
{
    public class MessageService : IMessageService
    {
        public void Publish<T>(T message, string queueName)
        {
            Console.WriteLine($"Event published to {queueName}");
        }
    }
}
