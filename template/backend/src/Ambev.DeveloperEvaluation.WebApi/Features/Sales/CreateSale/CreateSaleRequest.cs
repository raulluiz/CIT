using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequest
    {
        public string? SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string? Customer { get; set; }
        public string? Branch { get; set; }

        public List<SaleItem> Items { get; set; } = [];
    }
}
