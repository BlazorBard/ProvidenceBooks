#pragma checksum "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9919770fc8ef7f2410f3a86959347cddbe9b30ef"
// <auto-generated/>
#pragma warning disable 1591
namespace ProvidenceBooks.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<section class=\"hero\"></section>\r\n\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "categories");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "category-grid-container");
#nullable restore
#line 13 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
       if (category != null)
      {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, " Enjoy books on ");
            __builder.AddContent(9, 
#nullable restore
#line 15 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
                            category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "   \r\n       ");
            __builder.OpenComponent<ProvidenceBooks.Client.Shared.Components.ProductList>(11);
            __builder.AddAttribute(12, "CategoryId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 16 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
                                   category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
      }
      else
      {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
         foreach (Category item in CatService.Categories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "category-item grid-item");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/" + (
#nullable restore
#line 22 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
                                                               item.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
                                                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
                                                                        
    
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\FullStack\ProvidenceBooks\ProvidenceBooks\Client\Pages\Index.razor"
      
  [Parameter]
  public string CategoryUrl { get; set; }
  private Category category = null;

 protected override void OnParametersSet()
  {
    if(CategoryUrl != null)
    {
      category = CatService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
    }
    else
    {
      category = null;
    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CatService { get; set; }
    }
}
#pragma warning restore 1591
