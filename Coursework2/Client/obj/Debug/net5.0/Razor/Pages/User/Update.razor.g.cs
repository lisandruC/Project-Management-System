#pragma checksum "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7617be37071c860d7226a34c36147b8fdaadca82"
// <auto-generated/>
#pragma warning disable 1591
namespace Coursework2.Client.Pages.User
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Coursework2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Coursework2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Coursework2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/update/{UserId:guid}")]
    public partial class Update : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                          BackToMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<h3>Update User</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                 User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label class=\"control-label\">First Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                User.UserFirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserFirstName = __value, User.UserFirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserFirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __Blazor.Coursework2.Client.Pages.User.Update.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 16 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                  () => User.UserFirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label class=\"control-label\">Last Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                User.UserLastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserLastName = __value, User.UserLastName))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserLastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __Blazor.Coursework2.Client.Pages.User.Update.TypeInference.CreateValidationMessage_1(__builder2, 33, 34, 
#nullable restore
#line 22 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                  () => User.UserLastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label class=\"control-label\">Email</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                User.UserEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserEmail = __value, User.UserEmail))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __Blazor.Coursework2.Client.Pages.User.Update.TypeInference.CreateValidationMessage_2(__builder2, 45, 46, 
#nullable restore
#line 28 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                  () => User.UserEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "<label class=\"control-label\">Mobile</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                User.UserMobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserMobile = __value, User.UserMobile))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserMobile));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __Blazor.Coursework2.Client.Pages.User.Update.TypeInference.CreateValidationMessage_3(__builder2, 57, 58, 
#nullable restore
#line 34 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
                                  () => User.UserMobile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n    ");
                __builder2.AddMarkupContent(60, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Update.razor"
       
    [Parameter]
    public Guid UserId { get; set; }
    private User User { get; set; } = new User();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            User = await Http.GetFromJsonAsync<User>($"/api/Users/{UserId}");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private async void HandleValidSubmit()
    {
        try
        {
            var response = await Http.PutAsJsonAsync($"/api/Users/{User.UserId}", User);
            response.EnsureSuccessStatusCode();
            Navigation.NavigateTo("/user");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void BackToMenu()
    {
        Navigation.NavigateTo("/user");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Coursework2.Client.Pages.User.Update
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
