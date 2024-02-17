using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class PersonType
{
    public byte Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

 
}
