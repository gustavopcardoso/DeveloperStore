using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class GetSaleProfile : Profile
    {
        public GetSaleProfile()
        {
            CreateMap<GetSaleQuery, Sale>();
            CreateMap<Sale, GetSaleResult>();
        }
    }

    public class GetSaleItemProfile : Profile
    {
        public GetSaleItemProfile()
        {
            CreateMap<SaleItem, GetSaleItemResult>();
        }
    }
}
