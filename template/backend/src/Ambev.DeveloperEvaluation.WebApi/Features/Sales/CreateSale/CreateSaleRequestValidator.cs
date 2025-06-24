using Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.SaleNumber).NotNull();
        RuleFor(sale => sale.SaleDate).NotNull();
        RuleFor(sale => sale.Customer).NotNull().NotEmpty();
        RuleFor(sale => sale.Branch).NotNull().NotEmpty();
        RuleFor(sale => sale.Items)
            .NotNull()
            .NotEmpty()
            .WithMessage("Sale must have at least one item");
    }
}
