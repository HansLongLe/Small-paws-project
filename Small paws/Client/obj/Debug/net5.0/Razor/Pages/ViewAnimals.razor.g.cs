#pragma checksum "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44bb71de909ab984d017cf4678348001f5b2a64c"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAnimals")]
    public partial class ViewAnimals : ViewAnimalsRazor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewAnimals</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddMarkupContent(2, "<tr><th>picture</th>\r\n        <th>Id</th>\r\n        <th>Age</th>\r\n        <th>Animal type</th>\r\n        <th>Descripition</th>\r\n        <th>Washed</th>\r\n        <th>Fed</th>\r\n        <th>Vaccinated</th></tr>");
#nullable restore
#line 17 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
     if (Animals != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
         foreach (var animal in Animals)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "td");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 22 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                               ShownImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 23 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.AnimalType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 26 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 27 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Washed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 28 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Fed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 29 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
                     animal.Vaccinated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Pages\ViewAnimals.razor"
         
}

   

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
