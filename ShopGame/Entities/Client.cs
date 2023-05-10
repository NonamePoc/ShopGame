using System;
using System.Collections.Generic;

namespace ShopGame.Entities;

public partial class Client
{
    public int ClientId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
