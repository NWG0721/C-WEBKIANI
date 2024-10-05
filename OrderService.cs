using Microsoft.EntityFrameworkCore;

namespace Relations
{
    public class OrderService
        : IOrderService
    {
        private readonly ShopContext db;

        public OrderService(
            ShopContext db)
        {
            this.db = db;
        }

        public Order GetOrder(int id)
        {
            return db.Orders
                  .Include(p=>p.Items)
                 .FirstOrDefault(p => p.Id == id);
        }

        //public List<Order> GetOrders()
        //{
        //    return db.Orders.ToList();
        //}

        public int Init()
        {
            var rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                var order = new Order
                {
                    Buyer = $"Buyer{i}",
                    ShopingDate = DateTime.Now,
                    Items = new List<OrderItem> {
                     new OrderItem{
                      ProductName ="Pen",
                       Quantity= rnd.Next(10,200),
                        UnitPrice=17 * rnd.Next(10,200),
                     },
                     new OrderItem{
                      ProductName ="book",
                       Quantity= rnd.Next(5,100),
                        UnitPrice=17 * rnd.Next(50,350),
                     },
                      new OrderItem{
                      ProductName ="Pencil case",
                       Quantity= rnd.Next(15,80),
                        UnitPrice=17 * rnd.Next(40,90),
                     },
                    }
                };
                db.Orders.Add(order);
            }

            return db.SaveChanges();
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await db.Orders.ToListAsync();
        }
    }
}
