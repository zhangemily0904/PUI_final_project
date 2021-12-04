#pragma checksum "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0d4d35271b990106c578816f312d05056fa5dc"
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
#line 1 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using BlazorApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/emilyzhang/Desktop/BlazorApp/_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game")]
    public partial class GameContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"border-left\"></div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "game-container");
            __builder.AddAttribute(3, "tabindex", "0");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
                                                   _gameManager.StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 4 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
                                                                                     HandleKeyUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<div class=\"border-top\"></div>\n  ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sky");
#nullable restore
#line 7 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
     foreach (var score in _gameManager.Scores) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Components.Score>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Models.ScoreModel>(
#nullable restore
#line 8 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
                    score

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Components.Bird>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Models.BirdModel>(
#nullable restore
#line 10 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
                 _gameManager.Bird

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n  <div class=\"ground\"></div>");
#nullable restore
#line 14 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
   foreach (var pipe in _gameManager.Pipes) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Components.Pipe>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Models.PipeModel>(
#nullable restore
#line 15 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
                   pipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 16 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n<div class=\"border-right\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/emilyzhang/Desktop/BlazorApp/Components/GameContainer.razor"
       
  GameManager _gameManager;
  protected override void OnInitialized() {
    _gameManager = new GameManager();
    _gameManager.MainLoopCompleted += (o,e) => StateHasChanged(); 
  }
  void HandleKeyUp(KeyboardEventArgs e) {
    if (e.Key == " ") { 
      _gameManager.Jump();
    }
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591