using SalesOrderManager.Shared.Domain;

namespace SalesOrderManager.Api.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int orderId);
        Order AddOrder(Order order);
        Order UpdateOrder(Order order);
        void DeleteOrder(int orderId);
    }
}
