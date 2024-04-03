using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Inventory
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    public virtual User User { get; set; } = null!;

    public void Edit(string name , bool isActive )
    {
        Name = name;
        IsActive = isActive;
    }
}
