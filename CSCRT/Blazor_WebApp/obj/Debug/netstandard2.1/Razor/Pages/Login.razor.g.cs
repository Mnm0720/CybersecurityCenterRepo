#pragma checksum "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f25d1fd3e684ab6c979e0408d7b1b053813e91"
// <auto-generated/>
#pragma warning disable 1591
namespace CyberTool_BLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using CyberTool_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using CyberTool_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using BlazorFluentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using BlazorFluentUI.Demo.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\_Imports.razor"
using BlazorFluentUI.Demo.Shared.Utils;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, Professor/Student!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    Welcome to the Cybersecurity Publication Submision Tool (CPST)\r\n</p>\r\n");
            __builder.OpenComponent<BlazorFluentUI.BFUDefaultButton>(2);
            __builder.AddAttribute(3, "Text", "Sign In");
            __builder.AddAttribute(4, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                                           args => largeDialogOpen = true

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<BlazorFluentUI.BFUDialog>(6);
            __builder.AddAttribute(7, "SubText", "Please log in before continuing");
            __builder.AddAttribute(8, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                   largeDialogOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "IsBlocking", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                       isBlocking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "DialogType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFluentUI.DialogType>(
#nullable restore
#line 13 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                       DialogType.LargeHeader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnDismiss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                       args => largeDialogOpen = false 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "p");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<BlazorFluentUI.BFUTextField>(16);
                __builder2.AddAttribute(17, "Label", "Login:");
                __builder2.AddAttribute(18, "Placeholder", "Email");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<BlazorFluentUI.BFUTextField>(20);
                __builder2.AddAttribute(21, "Placeholder", "Password");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            ));
            __builder.AddAttribute(24, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<BlazorFluentUI.BFUDefaultButton>(26);
                __builder2.AddAttribute(27, "Text", "Cancel");
                __builder2.AddAttribute(28, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                                                  args => largeDialogOpen = false

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<BlazorFluentUI.BFUPrimaryButton>(30);
                __builder2.AddAttribute(31, "Text", "Submit");
                __builder2.AddAttribute(32, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
                                                  args => largeDialogOpen = false

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Eliel\Documents\GitHub\CybersecurityCenterRepo\CSCRT\Blazor_WebApp\Pages\Login.razor"
       
        bool dialogOpen = false;
        bool largeDialogOpen = false;
        string uncontrolledSingleSelectionResult;
        bool isBlocking = false;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
