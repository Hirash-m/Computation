using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Phone
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public bool IsMain { get; set; }

    public short Type { get; set; }

    public string? Phone1 { get; set; }

    public virtual Person Person { get; set; } = null!;
}
