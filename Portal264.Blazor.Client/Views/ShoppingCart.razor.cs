using Microsoft.AspNetCore.Components;
using Portal264.Blazor.Client.ViewModels;

namespace Portal264.Blazor.Client.Views
{
    public class ShoppingCartBase : ComponentBase
    {
        [Inject]
        public IShoppingCartViewModel ViewModel { get; set; }

        protected override void OnInit()
        {
            ViewModel.AddItemToCart("Intel Core i9-7980XE Skylake X 18", 1, 2049.99m);
            ViewModel.AddItemToCart("ASUS ROG Strix X99-E", 1, 299.99m);
            ViewModel.AddItemToCart("EVGA GeForce RTX 2080 Ti", 1, 1069.99m);
        }
    }
}
