using MiniCms.Mvc.Models;

namespace MiniCms.Mvc.Services;

public interface IAsyncCmsService
{
    // Метод для заказа еды
    Task<OrderViewModel> OrderAsync(OrderViewModel orderViewModel);
    // Метод для получения списка заказов
    Task<List<OrderViewModel>> GetOrdersAsync();
    Task<OrderViewModel> GetOrderByIdAsync(Guid id);
    Task UpdateOrderAsync(OrderViewModel orderViewModel);
    
}