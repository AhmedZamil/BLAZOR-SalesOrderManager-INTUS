using SalesOrderManager.Shared.Domain;

namespace SalesOrderManager.Api.Models
{
    public interface IWindowRepository
    {
        IEnumerable<Window> GetAllWindows();
        IEnumerable<Window> GetAllWindowsByOrderId(int orderId);
        Window GetWindowById(int windowId);
        Window AddWindow(Window window);
        Window UpdateWindow(Window window);
        void DeleteWindow(int orderId);
    }
}
