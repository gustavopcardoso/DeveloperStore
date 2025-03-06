using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleRepository(DefaultContext _context) : ISaleRepository
    {
        public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken)
        {
            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();

            return sale;
        }

        public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context
                .Sales.Include(p => p.SaleItems)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken)
        {
            _context.Sales.Update(sale);
            await _context.SaveChangesAsync();

            return sale;
        }

        public async Task<List<Sale>> GetAllAsync(string customerName, int page = 1, int size = 10, CancellationToken cancellationToken = default)
        {
            var query = await _context.Sales
                .Include(p => p.SaleItems)
                .Where(s => (String.IsNullOrEmpty(customerName) || s.CustomerName.ToLower().Contains(customerName.ToLower())))
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return query;
        }
    }
}
