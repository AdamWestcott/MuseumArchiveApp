// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MuseumArchivalAppServer.Pages
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
#nullable restore
#line 2 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\AboutText.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/InputAbout")]
    public partial class AboutText : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\AboutText.razor"
       
    public string textfile { get; set; } = string.Empty;

    string filePath;

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        textfile = "";
        var file = e.File;

        Stream stream = file.OpenReadStream();
        var path = Path.GetFullPath("wwwroot\\Text\\") + file.Name;
        FileStream fs = File.Create(path);
        await stream.CopyToAsync(fs);
        stream.Close();
        fs.Close();

        var lines = System.IO.File.ReadAllLines(path);
        foreach (string line in lines)
        {
            textfile += line + Environment.NewLine;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
