#pragma checksum "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28ae6c5f7c7d787ddaa1b3515c405dfc88f3d6b"
// <auto-generated/>
#pragma warning disable 1591
namespace Navbar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Navbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/_Imports.razor"
using Navbar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/Pages/Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<body>\n\n    \n    <header>\n        <nav class=\"nav-container fixed\">\n            <div class=\"nav-header\">\n                <div class=\"side-left\">\n\n                    <button class=\"btn-click\">Click</button>\n                    <div class=\"vehicle\">\n                        <input type=\"checkbox\" id=\"vehicle\" name=\"vehicle\" value=\"Bike\">\n                        <label for=\"vehicle\"> I have a bike</label><br>\n                    </div>\n                    <div class=\"vehicle\">\n                        <input type=\"checkbox\" id=\"car\" name=\"car\" value=\"car\" disabled>\n                        <label for=\"vehicle\"> I have Car</label><br>\n                    </div>\n\n                </div>\n\n                <ul class=\"list\">\n                    <li><a href=\"#\">Home</a></li>\n                    <li><a href=\"#\">About</a></li>\n                    <li><a href=\"#\">Projects</a></li>\n                    <li><a href=\"#\">Contact</a></li>\n                    <li><a href=\"#\">Projects Something</a></li>\n                    <li><a href=\"#\">Contact thinking</a></li>\n                </ul>\n            </div>\n        </nav>\n    </header>\n\n    <nav class=\"sidebar-container\">\n        <div class=\"text\">Side Bar</div>\n        <ul class=\"top-list\">\n            <li><a href=\"#\">Dashboard</a></li>\n            <li>\n                <i class=\"fas fa-chevron-right first\"></i>\n                <a href=\"#\">Features</a>\n                <ul class=\"sub-menu\">\n                    <li><a href=\"#\">Pages</a></li>\n                    <li>\n                        <a href=\"#\">Elements</a>\n                    </li>\n                </ul>\n            </li>\n            <li>\n                <i class=\"fas fa-chevron-right second\"></i>\n                <a href=\"#\">Services</a>\n\n                <ul class=\"sub-menu2\">\n                    <li><a href=\"#\">App Desingn</a></li>\n                    <li><a href=\"#\">Web Desingn</a></li>\n                </ul>\n            </li>\n            \n        </ul>\n\n    </nav>\n\n\n    \n    <div class=\"menu-header\">\n        <p>Menu</p>\n        <div class=\"toggle\">\n            <i class=\"fas fa-bars burger\" style=\"font-size:24px;\"> </i>\n            <i class=\"fas fa-times close\" style=\"font-size:24px;\"></i>\n        </div>\n    </div>\n\n\n    \n    <main>\n        <section class=\"main-container\">\n            <div class=\"patient-container\">\n\n\n\n            </div>\n\n            <div class=\"split-bar\">&nbsp;</div>\n\n            <div class=\"card-container\">\n\n            </div>\n\n\n        </section>\n    </main>\n\n\n</body>");
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "/Users/vimalraveendran/Desktop/blazor/Navbar/Navbar/Pages/Index.razor"
      
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("logUser", "Text after render");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
