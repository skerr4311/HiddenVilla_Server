#pragma checksum "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba1e8d19754bcfe6bdd0da85c77ca94f6893130e"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ParentComponent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Parent Child Component</h1>\r\n\r\n");
            __Blazor.HiddenVilla_Server.Pages.LearnBlazor.ParentComponent.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                        messageForGrandChild

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComp.ChildComponent>(4);
                __builder2.AddAttribute(5, "OnClickBtnMethod", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                                      ShowMessage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "Title", "This title is passed as a parameter from the parent");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Render Fragment from Parent");
                }
                ));
                __builder2.AddAttribute(9, "DangerChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Some danger heading");
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComp.AnotherChildComponent>(12);
            __builder.AddAttribute(13, "InputAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 11 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                                        InputAttributesFromParent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "p");
            __builder.OpenElement(16, "b");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
         messageText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\skerr\source\Unity_Projects\HiddenVilla_Server\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
       

    public Dictionary<string, object> InputAttributesFromParent { get; set; } = new Dictionary<string, object>()
    {
        {"required", "required" },
        {"placeholder", "This is set from the parent" },
        {"maxLength", 5 }
    };

    private string messageForGrandChild = "This is a message from Grand Parent";
    private string messageText = "";

    private void ShowMessage(MouseEventArgs e)
    {
        messageText = "Blazzing text from parent";
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.LearnBlazor.ParentComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
