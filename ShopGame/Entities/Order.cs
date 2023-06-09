﻿using System;
using System.Collections.Generic;

namespace ShopGame.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Client? Client { get; set; }
    
    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
