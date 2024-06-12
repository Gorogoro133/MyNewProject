using Microsoft.AspNetCore.Components;
using ShopOnline.Client.Services.Contracts;
using ShopOnline.Models.Dtos;

namespace OnlineShop.Client.Pages
{
    public class ProductBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }


    }
}
