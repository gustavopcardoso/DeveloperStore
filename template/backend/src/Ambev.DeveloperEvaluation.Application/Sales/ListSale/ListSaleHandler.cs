using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class ListSaleHandler(
        ISaleRepository _saleRepository,
        IMapper _mapper)
        : IRequestHandler<ListSaleQuery, List<ListSaleResult>>
    {
        public async Task<List<ListSaleResult>> Handle(ListSaleQuery request, CancellationToken cancellationToken)
        {            
            var sales = await _saleRepository.GetAllAsync(request.CustomerName, request.Page, request.Size, cancellationToken);

            var result = _mapper.Map<List<ListSaleResult>>(sales);
            return result;
        }
    }
}
