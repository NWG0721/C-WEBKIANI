namespace Relations
{
    public class Order
    {
        public int Id { get; set; }
        public string Buyer { get; set; }
        public DateTime ShopingDate { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
