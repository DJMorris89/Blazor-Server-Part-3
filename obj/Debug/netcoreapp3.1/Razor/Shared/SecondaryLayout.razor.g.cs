#pragma checksum "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e49e05dae51591c5aebce0167a01ed577c48e27"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\source\repos\HomeWork3\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class SecondaryLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::BlazorApp.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4 bg-danger");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<span class=\"flex-fill text-white\">Experimental Page</span>\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary mx-2");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
                                                       ThumbsUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n            <span class=\"oi oi-thumb-up\"></span> Approvals ");
#nullable restore
#line 11 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
__builder.AddContent(17, approvals);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary mx-2");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
                                                       ThumbsDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n            <span class=\"oi oi-thumb-down\"></span> Disapprovals ");
#nullable restore
#line 14 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
__builder.AddContent(24, disapprovals);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "content px-4");
            __builder.AddMarkupContent(30, "\r\n        ");
#nullable restore
#line 19 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
__builder.AddContent(31, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.OpenElement(34, "footer");
            __builder.AddAttribute(35, "class", "text-center");
            __builder.AddMarkupContent(36, "\r\n        Copyright ");
#nullable restore
#line 23 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
__builder.AddContent(37, DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, " By Vrail RavensBlood LLC\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\david\source\repos\HomeWork3\BlazorApp\Shared\SecondaryLayout.razor"
      
    private int approvals = 0;
    private int disapprovals = 0;

    private void ThumbsUp()
    {
        approvals += 1;
    }

    private void ThumbsDown()
    {
        disapprovals += 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
