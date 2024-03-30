using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Address
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public int? RegionId { get; set; }

    public bool IsMain { get; set; }

    public short TypeAdressId { get; set; }

    public string? Address1 { get; set; }

    public string? ZipCode { get; set; }

    public string? Title { get; set; }

    public virtual Person Person { get; set; } = null!;
}
