using Ambev.DeveloperEvaluation.Application.Sales;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Events.Sales;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.UpdateSale
{
    public class UpdateSaleHandler(
        ISaleRepository _saleRepository,
        IMessageService _messageBrokerService,
        IMapper _mapper)
        : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
    {
        public async Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.GetByIdAsync(request.Id, cancellationToken);
            if (sale == null)
                throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            if (sale.SaleStatus == SaleStatus.Cancelled)
                throw new InvalidOperationException($"Sale with ID {request.Id} is already deleted");

            _mapper.Map(request, sale);

            var updatedSale = await _saleRepository.UpdateAsync(sale, cancellationToken);
            var result = _mapper.Map<UpdateSaleResult>(updatedSale);

            _messageBrokerService.Publish(new SaleModifiedEvent(updatedSale), "sale_updated_queue");

            return result;
        }
    }
}
