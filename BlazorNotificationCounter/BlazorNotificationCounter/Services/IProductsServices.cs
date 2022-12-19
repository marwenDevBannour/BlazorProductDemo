using BlazorNotificationCounter.Data;

namespace BlazorNotificationCounter.Services
{
    public interface IProductsServices
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
