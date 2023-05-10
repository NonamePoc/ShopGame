using ShopGame.Entities;

namespace ShopGame.Models
{
    public class ViewShop
    {
        public IEnumerable<Game> Games { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }

        public IEnumerable<Client> Clients { get; set; }
    }
}
