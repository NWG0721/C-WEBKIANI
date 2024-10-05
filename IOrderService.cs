namespace Relations
{
    public interface IOrderService
    {
        int Init();
        //List<Order> GetOrders();
        Task<List<Order>> GetOrdersAsync();
        Order GetOrder(int id);

    }
}
