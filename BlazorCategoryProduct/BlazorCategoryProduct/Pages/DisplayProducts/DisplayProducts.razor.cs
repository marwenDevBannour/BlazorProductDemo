using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using ProductsCategory.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorCategoryProduct.Pages.DisplayProducts
{
    public partial class DisplayProducts
    {
        [Parameter]
        public IEnumerable<ProductDto> products { get; set; }
    }
}
