#pragma checksum "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComp\AnotherChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43e97cccd8fa47c8bef1878eeb3235ff5e0c633"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComp;

#line default
#line hidden
#nullable disable
    public partial class AnotherChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h4 class=\"text-primary pt-3\">Another Child Component</h4>\r\n    ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "id", "roomName");
            __builder.AddAttribute(4, "placeholder", 
#nullable restore
#line 3 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComp\AnotherChildComponent.razor"
                                       placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "required", 
#nullable restore
#line 3 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComp\AnotherChildComponent.razor"
                                                               required

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "maxlength", 
#nullable restore
#line 3 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComp\AnotherChildComponent.razor"
                                                                                     maxLength

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComp\AnotherChildComponent.razor"
       

    [Parameter]
    public string placeholder { get; set; }

    [Parameter]
    public string required { get; set; } = "required";

    [Parameter]
    public string maxLength { get; set; } = "10";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591