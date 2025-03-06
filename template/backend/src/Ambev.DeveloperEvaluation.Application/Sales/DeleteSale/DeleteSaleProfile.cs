using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class DeleteSaleProfile : Profile
    {
        public DeleteSaleProfile()
        {
            CreateMap<DeleteSaleResult, DeleteSaleCommand>();            
        }
    }
}
