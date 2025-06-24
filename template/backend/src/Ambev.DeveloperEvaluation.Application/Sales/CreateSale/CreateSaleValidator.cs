using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleValidator: AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleValidator() {
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
}
