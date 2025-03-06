using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class GetSaleHandler(
        ISaleRepository _saleRepository,
        IMapper _mapper)
        : IRequestHandler<GetSaleQuery, GetSaleResult>
    {
        public async Task<GetSaleResult> Handle(GetSaleQuery request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.GetByIdAsync(request.Id, cancellationToken);
            if (sale == null)
                throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            var result = _mapper.Map<GetSaleResult>(sale);

            return result;
        }    
    }
}
