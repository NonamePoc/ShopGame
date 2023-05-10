using System;
using System.Collections.Generic;

namespace ShopGame.Entities;

public partial class Game
{
    public int GameId { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public string? Developer { get; set; }

    public string? Publisher { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public decimal? Rating { get; set; }

    public decimal? Price { get; set; }
    
    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
