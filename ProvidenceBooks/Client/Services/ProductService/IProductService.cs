
using ProvidenceBooks.Shared;
using System.Collections.Generic;

namespace ProvidenceBooks.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();


    }


}