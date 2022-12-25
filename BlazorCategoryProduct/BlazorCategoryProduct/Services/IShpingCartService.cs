using ProductsCategory.Models.Dto;

namespace BlazorCategoryProduct.Services
{
    public interface IShpingCartService
    {
        event Action<int> onshopingCatChanged;

        Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAddDto);
        Task<CartItemDto> DeleteItem(int id);
        Task<List<CartItemDto>> GetItems(int userId);
        void RaiseOnshopingCatChanged(int totalQte);
        Task<CartItemDto> UpdateQty(CartItemQtyUpdateDto cartItemQtyUpdateDto);
    }
}