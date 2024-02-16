using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class User
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryTransaction> InventoryTransactionAcceptUserNavigations { get; set; } = new List<InventoryTransaction>();

    public virtual ICollection<InventoryTransaction> InventoryTransactionCreateUserNavigations { get; set; } = new List<InventoryTransaction>();

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual Person Person { get; set; } = null!;
}
