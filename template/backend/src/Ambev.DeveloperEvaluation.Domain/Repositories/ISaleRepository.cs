using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken);
        Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken);
        Task<List<Sale>> GetAllAsync(string customerName, int page = 1, int size = 10, CancellationToken cancellationToken = default);
    }
}
