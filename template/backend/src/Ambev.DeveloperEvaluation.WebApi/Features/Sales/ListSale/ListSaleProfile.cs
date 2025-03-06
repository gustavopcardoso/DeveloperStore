using Ambev.DeveloperEvaluation.Application.Sales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale
{
    public class ListSaleProfile : Profile
    {
        public ListSaleProfile()
        {
            CreateMap<ListSaleRequest, ListSaleQuery>();
            CreateMap<ListSaleResult, ListSaleResponse>();
        }

        public class ListSaleItemProfile : Profile
        {
            public ListSaleItemProfile()
            {
                CreateMap<ListSaleItemResult, ListSaleItemResponse>();
            }
        }
    }
}
