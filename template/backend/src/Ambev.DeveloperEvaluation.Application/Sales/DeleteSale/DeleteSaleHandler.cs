using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Events.Sales;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class DeleteSaleHandler(
        ISaleRepository _saleRepository,
        IMessageService _messageBrokerService)
        : IRequestHandler<DeleteSaleCommand, DeleteSaleResult>
    {
        public async Task<DeleteSaleResult> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.GetByIdAsync(request.Id, cancellationToken);

            if (sale == null)
                throw new KeyNotFoundException($"Sale with ID {request.Id} not found");

            if (sale.SaleStatus == SaleStatus.Cancelled)
                throw new InvalidOperationException($"Sale with ID {request.Id} is already deleted");

            sale.SaleStatus = SaleStatus.Cancelled;

            await _saleRepository.UpdateAsync(sale, cancellationToken);

            _messageBrokerService.Publish(new SaleCancelledEvent(request.Id), "sale_cancelled_queue");

            return new DeleteSaleResult { Success = true };
        }
    }
}
