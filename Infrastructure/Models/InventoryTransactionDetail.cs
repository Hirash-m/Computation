using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class InventoryTransactionDetail
{
    public int Id { get; set; }

    public int InventoryTransactionId { get; set; }

    public int ProductId { get; set; }

    public decimal Amount { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual InventoryTransaction IdNavigation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
