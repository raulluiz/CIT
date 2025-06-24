using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleItem : BaseEntity
{
    public Guid? ProductId { get; set; }
    public string ProductName { get; set; }

    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; private set; }
    public decimal TotalAmount { get; private set; }
    public bool IsCancelled { get; private set; }

    public void CalculateItem()
    {
        Discount = 0;

        if (Quantity >= 4 && Quantity < 10)
            Discount = 0.10m;
        else if (Quantity >= 10 && Quantity <= 20)
            Discount = 0.20m;
        else if (Quantity > 20)
            throw new Exception("Cannot sell more than 20 identical items.");

        if (Quantity < 4)
            Discount = 0;

        TotalAmount = Quantity * UnitPrice * (1 - Discount);
    }

    public void Cancel()
    {
        IsCancelled = true;
    }
}
