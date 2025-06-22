using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public string SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Customer { get; set; }
        public string Branch { get; set; }
        public decimal TotalAmount { get; private set; }
        public bool IsCancelled { get; private set; }

        public List<SaleItem> Items { get; set; } = new();

        public void CalculateTotal()
        {
            TotalAmount = Items.Sum(i => i.TotalAmount);
        }

        public void Cancel()
        {
            IsCancelled = true;
            // Log SaleCancelled Event
        }

        //public void AddItem(ProductInfo product, int quantity, decimal unitPrice)
        //{
        //    if (IsCancelled)
        //        throw new Exception("Cannot add items to a cancelled sale");

        //    if (quantity > 20)
        //        throw new Exception("Cannot sell more than 20 identical items");

        //    var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        //    if (existingItem != null)
        //    {
        //        existingItem.IncreaseQuantity(quantity);
        //    }
        //    else
        //    {
        //        var item = new SaleItem(product, quantity, unitPrice);
        //        Items.Add(item);
        //    }

        //    CalculateTotal();
        //}
    }
}
