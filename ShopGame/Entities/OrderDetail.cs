using System;
using System.Collections.Generic;

namespace ShopGame.Entities;

public partial class OrderDetail
{
    public int? OrderId { get; set; }

    public int? GameId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Game? Game { get; set; }

    public virtual Order? Order { get; set; }
}
