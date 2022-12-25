using ProductsCategory.Models.Dto;

namespace BlazorCategoryProduct.Services
{
    public interface IProductService
    {
        Task<ProductDto> GetItem(int id);
        Task<IEnumerable<ProductDto>> GetItems();
    }
}