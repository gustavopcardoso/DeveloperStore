using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale
{
    public class UpdateSaleValidator : AbstractValidator<UpdateSaleRequest>
    {
        public UpdateSaleValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty();
            RuleFor(x => x.BranchName).NotEmpty();
        }        
    }    
}
