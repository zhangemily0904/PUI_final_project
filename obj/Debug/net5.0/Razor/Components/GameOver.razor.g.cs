#pragma checksum "/Users/emilyzhang/Desktop/PUI_final_project/Components/GameOver.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512bb3de4371c8ee0276aac81650dc384cc18cfb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using BlazorApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/emilyzhang/Desktop/PUI_final_project/_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
    public partial class GameOver : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "gameover");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 1 "/Users/emilyzhang/Desktop/PUI_final_project/Components/GameOver.razor"
                              _gameoverCSS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "/Users/emilyzhang/Desktop/PUI_final_project/Components/GameOver.razor"
       
  [Parameter] public GameOverModel Model { get; set; }
  string _gameoverCSS = $"background-image: url('../images/gameover.png'); background-repeat: no-repeat; width: 200px; left: 160px; height: 250px; position: absolute";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
