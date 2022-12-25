using BlazorCategoryProduct.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using ProductsCategory.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsCategory.Models.Dto;

namespace BlazorCategoryProduct.Pages.DetailsProducts
{
    public partial class DetailsProducts
    {
        [Parameter]
        public int id { get; set; }
        [Inject]
        public IProductService productService { get; set; }
        [Inject]
        public IShpingCartService shoppingCartService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public ProductDto product { get; set; }
        public string errorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                product = await productService.GetItem(id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var cartItemDto = await shoppingCartService.AddItem(cartItemToAddDto);
                navigationManager.NavigateTo("/ShoppingCart");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
