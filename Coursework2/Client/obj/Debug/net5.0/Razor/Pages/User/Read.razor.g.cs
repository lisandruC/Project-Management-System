#pragma checksum "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347a34a9d1a66f8daa36092c9d304f64e0729782"
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
#line 3 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/details/{UserId:guid}")]
    public partial class Read : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
                                          BackToMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<h3>Read User Details</h3>\r\n\r\n");
            __builder.AddMarkupContent(6, "<h4>Full Name</h4>\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 11 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
    user.UserFirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
    user.UserLastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.AddMarkupContent(13, "<h4>Email</h4>\r\n");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
    user.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.AddMarkupContent(17, "<h4>Mobile</h4>\r\n");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
    user.UserMobile

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\Read.razor"
       
    [Parameter]
    public Guid UserId { get; set; }
    private User user { get; set; } = new User();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            user = await Http.GetFromJsonAsync<User>($"/api/Users/{UserId}");

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
#pragma warning restore 1591
