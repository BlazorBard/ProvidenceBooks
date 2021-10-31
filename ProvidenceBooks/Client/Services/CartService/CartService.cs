using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvidenceBooks.Shared;
using ProvidenceBooks.Client;



namespace ProvidenceBooks.Client.Services.CartService
{
   public class CartService : ICartService
   {
       public IList<Product> Cart { get; private set; }
       public int Total { get; set; }
        public event Action OnChange;

        public CartService()
        {
            Cart = new List<Product>();
        }
        private void NotifyStateHasChanged() => OnChange?.Invoke();

        public void AddProduct(Product product)
        {
            Cart.Add(product);
            Total += product.Price;
            NotifyStateHasChanged();
        }

        public void DeleteProduct(Product product)
        {
            Cart.Remove(product);
            Total -= product.Price;
            NotifyStateHasChanged();
        }
    }
}