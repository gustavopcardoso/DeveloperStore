using Ambev.DeveloperEvaluation.Application.Sales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    public class DeleteSaleProfile : Profile
    {
        public DeleteSaleProfile()
        {
            CreateMap<DeleteSaleRequest, DeleteSaleCommand>();
            CreateMap<DeleteSaleResult, DeleteSaleResponse>();
        }
    }
}
