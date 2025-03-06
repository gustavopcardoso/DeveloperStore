using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty();
            RuleFor(x => x.BranchName).NotEmpty();
            RuleFor(x => x.SaleItems).NotEmpty();
            RuleForEach(x => x.SaleItems).SetValidator(new CreateSaleItemValidator());
        }
    }
    public class CreateSaleItemValidator : AbstractValidator<CreateSaleItemRequest>
    {
        public CreateSaleItemValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.Quantity).GreaterThan(0);
            RuleFor(x => x.UnitPrice).GreaterThan(0);
        }
    }
}
