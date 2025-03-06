using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class UpdateSaleProfile : Profile
    {
        public UpdateSaleProfile() 
        {
            CreateMap<UpdateSaleCommand, Sale>();
            CreateMap<Sale, UpdateSaleResult>();
        }
    }
}
