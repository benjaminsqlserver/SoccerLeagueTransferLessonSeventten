#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd9f2c548a32ced38028050cb52f98883f5bd1b"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/confirm-delete-role/{RoleID}")]
    public partial class ConfirmDeleteRole : SoccerLeagueTransferApp.Pages.ConfirmDeleteRoleComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<SoccerLeagueTransferApp.Models.ConData.Role>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SoccerLeagueTransferApp.Models.ConData.Role>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                   role

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                                                                                        role != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.Role>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.Role>(this, 
#line 12 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                                                                                                                Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(23);
                    __builder3.AddAttribute(24, "Size", "H1");
                    __builder3.AddAttribute(25, "Text", "Role");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(31, "class", "row");
                    __builder3.AddMarkupContent(32, "\n              ");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "col-md-3");
                    __builder3.AddMarkupContent(35, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(36);
                    __builder3.AddAttribute(37, "Size", "H3");
                    __builder3.AddAttribute(38, "style", "width: 337px");
                    __builder3.AddAttribute(39, "Text", "Confirm If You Want To Delete This Role");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(45, "class", "row");
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-3");
                    __builder3.AddMarkupContent(49, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
                    __builder3.AddAttribute(51, "Component", "RoleName");
                    __builder3.AddAttribute(52, "style", "width: 100%");
                    __builder3.AddAttribute(53, "Text", "Role Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "col-md-9");
                    __builder3.AddMarkupContent(58, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(59);
                    __builder3.AddAttribute(60, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                     $"{(role.RoleName)}"

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "row");
                    __builder3.AddMarkupContent(66, "\n              ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(70);
                    __builder3.AddAttribute(71, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(72, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(73, "Icon", "close");
                    __builder3.AddAttribute(74, "Text", "Delete Role");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(76);
                    __builder3.AddAttribute(77, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(78, "Text", "Cancel");
                    __builder3.AddAttribute(79, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 40 "C:\SoccerLeagueTransfer\server\Pages\ConfirmDeleteRole.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
