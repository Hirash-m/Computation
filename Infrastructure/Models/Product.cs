using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsService { get; set; }

    public decimal UnitPrice { get; set; }

    public DateTime LastPriceUpdate { get; set; }

    public bool SaleAble { get; set; }

    public byte UnitId { get; set; }

    public virtual ICollection<InventoryTransactionDetail> InventoryTransactionDetails { get; set; } = new List<InventoryTransactionDetail>();
}
