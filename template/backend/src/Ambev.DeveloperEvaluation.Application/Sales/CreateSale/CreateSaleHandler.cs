using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using Ambev.DeveloperEvaluation.Domain.Events.Sales;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleHandler(
        ISaleRepository _saleRepository,
        IMessageService _messageBrokerService,
        IMapper _mapper)
        : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        public async Task<CreateSaleResult> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = _mapper.Map<Sale>(request);
            
            sale.CheckDuplicates();
            sale.CheckQuantity();
            sale.CalculateDiscounts();
            sale.CalculateTotalAmount();       

            var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);
            var result = _mapper.Map<CreateSaleResult>(createdSale);

            _messageBrokerService.Publish(new SaleCreatedEvent(sale), "sale_created_queue");

            return result;
        }
    }
}
