using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class InventoryTransaction
{
    public int Id { get; set; }

    public short InventoryId { get; set; }

    public DateOnly CreateDate { get; set; }

    public DateOnly AcceptDate { get; set; }

    public string? Number { get; set; }

    public int? CreateUser { get; set; }

    public int? AcceptUser { get; set; }

    public virtual User? AcceptUserNavigation { get; set; }

    public virtual User? CreateUserNavigation { get; set; }

    public virtual Inventory Inventory { get; set; } = null!;

    public virtual InventoryTransactionDetail? InventoryTransactionDetail { get; set; }
}
