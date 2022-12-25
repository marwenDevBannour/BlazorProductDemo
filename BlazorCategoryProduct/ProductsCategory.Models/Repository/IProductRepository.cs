using ProductsCategory.Models.Entities;

namespace ProductsCategory.Models.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<ProductCategory> GetCategory(int id);
        Task<Product> GetItem(int id);
        Task<IEnumerable<Product>> GetItems();
    }
}