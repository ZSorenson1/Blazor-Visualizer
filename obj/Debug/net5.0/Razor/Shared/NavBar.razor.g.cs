#pragma checksum "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9560841b278ab2b3e454e61bab20197470d21888"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Visualizer.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Blazor_Visualizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using Blazor_Visualizer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navbar");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\Shared\NavBar.razor"
                        e => sortComponent.FillArray()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "New Array");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\Shared\NavBar.razor"
                        e => CallBubbleSort()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Bubble Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\Shared\NavBar.razor"
                        e => sortComponent.RunSort()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Run");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Zach\Desktop\Projects\Blazor-Visualizer\Shared\NavBar.razor"
      
    public void CallBubbleSort()
    {
        sortComponent.bubbleSort = true;
    }
    public void CallMergeSort()
    {
        sortComponent.mergeSort = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SortingComponentBase sortComponent { get; set; }
    }
}
#pragma warning restore 1591