#pragma checksum "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e811d1dd79573090425f2e6a0afdb4e9116418c58afee57021ac7ee70b1d0423"
// <auto-generated/>
#pragma warning disable 1591
namespace MuseumArchivalAppServer.Pages
{
    #line hidden
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
#line 4 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using Telerik.ReportViewer.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Report/{Id}")]
    public partial class Report : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .trv-report-viewer {\r\n        width: 100%;\r\n        height: 880px;\r\n    }\r\n</style>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "href", (object)("archive"));
            __builder.AddAttribute(3, "class", (object)("btn btn-secondary"));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Back to Archival");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "dashboard");
            __builder.OpenComponent<global::Telerik.ReportViewer.Blazor.ReportViewer>(9);
            __builder.AddAttribute(10, "ViewerID", (object)("rv1"));
            __builder.AddAttribute(11, "ServiceUrl", (object)("/api/reports"));
            __builder.AddAttribute(12, "ReportSource", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Telerik.ReportViewer.Blazor.ReportSourceOptions>(
#nullable restore
#line 26 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
                                  new ReportSourceOptions
                                  {
                                      Report ="Report1.trdp",
                                      Parameters = new Dictionary<string, object>
                                       {
                                          {"pictureBox1", ArchivalItemModel.ArchivalItemImage},
                                          { "ItemTitle", ArchivalItemModel.ArchivalItemName },
                                          { "ItemShortDescription", ArchivalItemModel.ArchivalItemShortDescription },
                                          { "ItemLongDescription", ArchivalItemModel.ArchivalItemLongDescription }
                                       }

                                  }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n<link href=\"css/dashboard.css\" rel=\"stylesheet\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Report.razor"
       
    [Parameter]
#nullable enable
    public string? Id { get; set; }
#nullable disable
    private ArchivalItemDTO ArchivalItemModel { get; set; } = new ArchivalItemDTO();
    string archivalImage = "";

    protected override async Task OnInitializedAsync()
    {
        ArchivalItemModel = await ArchivalRepository.GetArchivalItem(Id);
        archivalImage = "data:image/jpg;base64, " + Convert.ToBase64String(ArchivalItemModel.ArchivalItemImage);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArchivalItemRepository ArchivalRepository { get; set; }
    }
}
#pragma warning restore 1591
