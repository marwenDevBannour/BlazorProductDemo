using BlazorCategoryProduct.Helpers;
using BlazorCategoryProduct.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using ProductsCategory.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorCategoryProduct.Pages.Products
{
    public partial class Products
    {
        [Inject]
        public IProductService productService { get; set; }

        [Inject]
        public IShpingCartService shoppingCartService { get; set; }

        public IEnumerable<ProductDto> products { get; set; }

        public string errorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                products = await productService.GetItems();
                var shoppingCartItems = await shoppingCartService.GetItems(HardCoded.UserId);

                var totalQty = shoppingCartItems.Sum(s => s.Qty);

                shoppingCartService.RaiseOnshopingCatChanged(totalQty);
            }
            catch (Exception ex)
            {

               errorMessage = ex.Message;
            }
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            var res = from product in products
                      group product by product.CategoryId into prodByCatGroup
                      orderby prodByCatGroup.Key
                      select prodByCatGroup;
            return res;
            
        }
        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDtos)
        {
            var res= groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
            return res;
        }
    }
}
