using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Sale>()
                .ForMember(dest => dest.SaleItems, opt => opt.MapFrom(src => src.SaleItems));
            CreateMap<Sale, CreateSaleResult>()
                .ForMember(dest => dest.SaleItems, opt => opt.MapFrom(src => src.SaleItems));
        }
    }

    public class CreateSaleItemProfile : Profile
    {
        public CreateSaleItemProfile()
        {
            CreateMap<CreateSaleItemCommand, SaleItem>();
            CreateMap<SaleItem, CreateSaleItemResult>();
        }
    }
}
