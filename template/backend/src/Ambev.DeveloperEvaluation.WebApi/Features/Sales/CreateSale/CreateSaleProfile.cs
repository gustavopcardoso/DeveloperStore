using Ambev.DeveloperEvaluation.Application.Sales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleRequest, CreateSaleCommand>()
                .ForMember(dest => dest.SaleItems, opt => opt.MapFrom(src => src.SaleItems));
            CreateMap<CreateSaleResult, CreateSaleResponse>();
        }
    }

    public class CreateSaleItemProfile : Profile
    {
        public CreateSaleItemProfile()
        {
            CreateMap<CreateSaleItemRequest, CreateSaleItemCommand>();
            CreateMap<CreateSaleItemResult, CreateSaleItemResponse>();
        }
    }
}
