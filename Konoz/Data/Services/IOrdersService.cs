using Konoz.Models;

namespace Konoz.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAdress);
        Task<List<Order>> GetOrderByUserIdAndRoleAsync(string userId, string userRole);
    }
}
