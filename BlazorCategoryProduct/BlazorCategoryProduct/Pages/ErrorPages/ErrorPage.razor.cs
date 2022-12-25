using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorCategoryProduct.Pages.ErrorPages
{
    public partial class ErrorPage
    {
        [Parameter]
        public string ErrorMessage { get; set; }
    }
}
