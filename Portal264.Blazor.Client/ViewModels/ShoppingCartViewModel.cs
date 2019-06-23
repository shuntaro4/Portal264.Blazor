using Portal264.Blazor.Shared;
using System.Collections.Generic;
using System.Globalization;

namespace Portal264.Blazor.Client.ViewModels
{
    public interface IShoppingCartViewModel
    {
        List<InventoryItem> Cart { get; set; }

        void AddItemToCart(string name, int quantity, decimal price);
        string DisplayPrice(decimal price);
        InventoryItem DisplayTotal();
    }


    public class ShoppingCartViewModel : IShoppingCartViewModel
    {
        private List<InventoryItem> _cart;

        public List<InventoryItem> Cart
        {
            get => _cart;
            set => _cart = value;
        }

        public void AddItemToCart(string name, int quantity, decimal price)
        {
            var newItem = new InventoryItem
            {
                Name = name,
                Quantity = quantity,
                Price = price
            };
            _cart.Add(newItem);
        }

        public string DisplayPrice(decimal price)
        {
            var numberFormat = (NumberFormatInfo)CultureInfo.CurrentUICulture.NumberFormat.Clone();
            numberFormat.CurrencySymbol = "$";
            return price.ToString("C", numberFormat);
        }

        public InventoryItem DisplayTotal()
        {
            var result = new InventoryItem();
            result.Name = "Total";

            foreach (var item in Cart)
            {
                result.Quantity += item.Quantity;
                result.Price += item.Price;
            }
            return result;
        }

        public ShoppingCartViewModel()
        {
            _cart = new List<InventoryItem>();
        }
    }
}
