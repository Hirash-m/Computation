using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Family { get; set; } = null!;

    public string? NationalCode { get; set; }

    public byte TypeId { get; set; }

    public string? Email { get; set; }

    public int? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ModifiUser { get; set; }

    public DateTime? ModifiDate { get; set; }

    public decimal? CustomerRemaining { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual User? CreateUserNavigation { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    public virtual PersonType Type { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public void Edit(int id, string name, string family, string nationalCode,
                      byte typeid, string email, ICollection<Phone> phones,
                      ICollection<Address> addresses) // Added 'addresses' parameter
    {
        Id = id;
        Name = name;
        Family = family;
        NationalCode = nationalCode;
        TypeId = typeid;
        Email = email;
        Phones = phones;
        Addresses = addresses; // Added 'Addresses' assignment
    }

}
