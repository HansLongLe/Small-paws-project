#pragma checksum "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3e0377a1bb2ec331b3f59f706c96f74cc8b6968"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor"
 if(_navigationManager.Uri.Contains("Login" )|| _navigationManager.Uri.Contains("CreateAccountMain")|| _navigationManager.Uri.Contains("CreateAccountDetails"))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ocnk4r8tjs");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor"
}
else
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-ocnk4r8tjs");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar");
            __builder.AddAttribute(9, "b-ocnk4r8tjs");
            __builder.OpenComponent<Client.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "main");
            __builder.AddAttribute(14, "b-ocnk4r8tjs");
            __builder.AddMarkupContent(15, "<div class=\"top-row px-4\" b-ocnk4r8tjs><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-ocnk4r8tjs>About</a></div>\r\n\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-ocnk4r8tjs");
            __builder.AddContent(19, 
#nullable restore
#line 23 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\hansl\Documents\GitHub\Small-paws-project\Small paws\Client\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
