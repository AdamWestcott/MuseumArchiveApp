#pragma checksum "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b42253aa3142599153d658ed4412662e4f4fc929aeab55a6c0d321fb2024f1f5"
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
#line 2 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Collections")]
    public partial class Collections : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        #svfmodal {
            display: flex
        }

        .modal-fullscreen {
            width: 100vw;
            max-width: none;
            height: 100%;
            margin: 0;
            overflow-y: hidden;
            padding-right: 15px;
            padding-left: 15px;
            padding-top: 15px
        }

        .modal-dialog {
            position: initial;
        }

        .modal-header {
            border-bottom: 0px !important;
        }

        body.modal-open {
        }

        input::-webkit-outer-spin-button,
        input::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }

        input[type=number] {
            -moz-appearance: textfield;
        }

        .my-custom-actions .k-window-titlebar {
            background: linear-gradient(180deg, rgb(5, 39, 103) 0%, #416FE9 70%) !important;
            /*color: green !important;     ----->Colour of Text*/
        }

        customfloat {
            float: right !important;
        }

        .checkbox-style {
            border-color: black;
        }

            .checkbox-style:checked {
                border-color: black;
            }

        .numeric-style {
            border-color: black;
        }
    </style>
    ");
            __builder.AddMarkupContent(1, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Collections</h4></div>\r\n<br>\r\n");
            global::__Blazor.MuseumArchivalAppServer.Pages.Collections.TypeInference.CreateTelerikDropDownList_0(__builder, 2, 3, 
#nullable restore
#line 82 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                            collectionsList

#line default
#line hidden
#nullable disable
            , 4, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Object>(this, 
#nullable restore
#line 84 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                               selectCollection

#line default
#line hidden
#nullable disable
            ), 5, "CollectionName", 6, "CollectionID", 7, "Select Collection", 8, "100%", 9, 
#nullable restore
#line 83 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                   CollectionID

#line default
#line hidden
#nullable disable
            , 10, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CollectionID = __value, CollectionID)), 11, () => CollectionID);
            __builder.AddMarkupContent(12, "\r\n<br>");
#nullable restore
#line 91 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
 if (isCollectionSelected == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<br>\r\n    ");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenDataGrid<ArchivalItemDTO>>(14);
            __builder.AddAttribute(15, "AllowSorting", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 94 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "AllowFiltering", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 94 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "FilterMode", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterMode>(
#nullable restore
#line 94 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                        Radzen.FilterMode.Simple

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "Data", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<ArchivalItemDTO>>(
#nullable restore
#line 95 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                           ArchivalItems

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "FilterCaseSensitivity", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 95 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                         Radzen.FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "LogicalFilterOperator", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.LogicalFilterOperator>(
#nullable restore
#line 96 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                           Radzen.LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "AllowPaging", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 96 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "PageSize", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 96 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                         5

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "AllowColumnResize", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 96 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                                               true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "Columns", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenDataGridColumn<ArchivalItemDTO>>(25);
                __builder2.AddAttribute(26, "Title", (object)("Image"));
                __builder2.AddAttribute(27, "Width", (object)("250px"));
                __builder2.AddAttribute(28, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 99 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                            false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ArchivalItemDTO>)((data) => (__builder3) => {
#nullable restore
#line 101 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                     if (data.ArchivalItemImage != null)
                    {
                        //getUnitImage(data.UnitId);
                        archivalImage = "data:image/jpg;base64, " + Convert.ToBase64String(data.ArchivalItemImage);
                    }

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::Radzen.Blazor.RadzenImage>(30);
                    __builder3.AddAttribute(31, "Path", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 106 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                        archivalImage

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(32, "style", (object)("width: 80px; height: 80px; border-radius: 8px;"));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenDataGridColumn<ArchivalItemDTO>>(34);
                __builder2.AddAttribute(35, "Property", (object)("UnitName"));
                __builder2.AddAttribute(36, "Title", (object)("Name"));
                __builder2.AddAttribute(37, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 109 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                                      false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(38, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ArchivalItemDTO>)((data) => (__builder3) => {
#nullable restore
#line 111 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
__builder3.AddContent(39, data.ArchivalItemName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenDataGridColumn<ArchivalItemDTO>>(41);
                __builder2.AddAttribute(42, "Property", (object)("UnitDescription"));
                __builder2.AddAttribute(43, "Title", (object)("Brief Description"));
                __builder2.AddAttribute(44, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 114 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                                                          false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ArchivalItemDTO>)((data) => (__builder3) => {
#nullable restore
#line 116 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
__builder3.AddContent(46, data.ArchivalItemShortDescription);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenDataGridColumn<ArchivalItemDTO>>(48);
                __builder2.AddAttribute(49, "Property", (object)("UnitDescription"));
                __builder2.AddAttribute(50, "Title", (object)("Creation Date"));
                __builder2.AddAttribute(51, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 119 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                                                                                                                                      false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(52, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ArchivalItemDTO>)((data) => (__builder3) => {
#nullable restore
#line 121 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
__builder3.AddContent(53, data.ArchivalItemCreationDate);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenDataGridColumn<ArchivalItemDTO>>(55);
                __builder2.AddAttribute(56, "Title", (object)("Action"));
                __builder2.AddAttribute(57, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ArchivalItemDTO>)((data) => (__builder3) => {
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(58, (__value) => {
#nullable restore
#line 94 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
                          radzenArchivalItemGrid = (Radzen.Blazor.RadzenDataGrid<ArchivalItemDTO>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 130 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\adam2\Documents\MuesumArchiveApp\MuseumArchiveApp\MuseumArchivalAppServer\Pages\Collections.razor"
       
    string CollectionID = "";
    bool isCollectionSelected = false;
    IEnumerable<CollectionDTO> collections;
    List<CollectionDTO> collectionsList = new List<CollectionDTO>();
    private IEnumerable<ArchivalItemDTO> ArchivalItems { get; set; } = new List<ArchivalItemDTO>();
    RadzenDataGrid<ArchivalItemDTO> radzenArchivalItemGrid;
    string archivalImage = "";

    protected override async Task OnInitializedAsync()
    {
        collections = await CollectionRepository.GetAllCollections();
        collectionsList = collections.ToList();
    }

    public async void selectCollection()
    {
        isCollectionSelected = true;
        ArchivalItems = await ArchivalRepository.GetAllArchivalItems();
        ArchivalItems = ArchivalItems.Where(x => x.CollectionId == CollectionID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICollectionRepository CollectionRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IKeywordTagGroupRepository KeywordTagGroupRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IKeywordTagRepository KeywordTagRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArchivalItemRepository ArchivalRepository { get; set; }
    }
}
namespace __Blazor.MuseumArchivalAppServer.Pages.Collections
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikDropDownList_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikDropDownList<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", (object)__arg0);
        __builder.AddAttribute(__seq1, "OnChange", (object)__arg1);
        __builder.AddAttribute(__seq2, "TextField", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueField", (object)__arg3);
        __builder.AddAttribute(__seq4, "DefaultText", (object)__arg4);
        __builder.AddAttribute(__seq5, "Width", (object)__arg5);
        __builder.AddAttribute(__seq6, "Value", (object)__arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", (object)__arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", (object)__arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591