#pragma checksum "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\CartBtnComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581632fb2ccde07bb9e291cd2374275671b96c00"
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
#line 13 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Client.Services.CartService;

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
#line 15 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\_Imports.razor"
using ProvidenceBooks.Shared;

#line default
#line hidden
#nullable disable
    public partial class CartBtnComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\CartBtnComponent.razor"
                                             () =>
                      CS.AddProduct(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n                    Add to Cart\r\n                ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Shared\Components\CartBtnComponent.razor"
                       
                     private Product product = null;

   

   
                

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CS { get; set; }
    }
}
#pragma warning restore 1591
