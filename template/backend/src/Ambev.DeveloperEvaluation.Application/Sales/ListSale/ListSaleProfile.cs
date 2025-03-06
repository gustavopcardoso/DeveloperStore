using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class ListSaleProfile : Profile
    {
        public ListSaleProfile()
        {
            CreateMap<Sale, ListSaleResult>();
        }        
    }

    public class ListSaleItemProfile : Profile
    {
        public ListSaleItemProfile()
        {
            CreateMap<SaleItem, ListSaleItemResult>();
        }
    }
}
