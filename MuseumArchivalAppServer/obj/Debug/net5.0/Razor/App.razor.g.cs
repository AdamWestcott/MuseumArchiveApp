#pragma checksum "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f176622c93fc26fc6f8ed40850922ed4f467d6fac40133cdbb990110826cf00d"
// <auto-generated/>
#pragma warning disable 1591
namespace MuseumArchivalAppServer
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using MuseumArchivalAppServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using MuseumArchivalAppServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "PreferExactMatches", (object)(
#nullable restore
#line 1 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 3 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 6 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
