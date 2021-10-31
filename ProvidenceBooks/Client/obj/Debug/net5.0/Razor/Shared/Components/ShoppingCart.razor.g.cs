#pragma checksum "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e77e3e045340ce1273c6b70272a246dc2cedecc"
// <auto-generated/>
#pragma warning disable 1591
namespace ProvidenceBooks.Client.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
using ProvidenceBooks.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
using ProvidenceBooks.Client.Services.CartService;

#line default
#line hidden
#nullable disable
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cart-section");
#nullable restore
#line 9 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
     if (CS.Cart.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h2>Your Cart</h2>\r\n        ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "cart-list");
#nullable restore
#line 13 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
             foreach (Product item in CS.Cart)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", "cart-content");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "product-image");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", "/images/" + (
#nullable restore
#line 17 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                                           item.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 17 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                                                             item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n                  \r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "cart-info");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                         item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " - $");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                                              item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                      ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-sm");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                                        ()
                             => CS.DeleteProduct(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span class=\"oi oi-delete\">\r\n                            Delete\r\n                        </span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "p-2");
            __builder.OpenElement(26, "h3");
            __builder.AddContent(27, "Total: $");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
                         CS.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\ShoppingCart.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService PS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
