#pragma checksum "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96fdae34c51435f732ab7543dbb295750bd3fd4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>User List</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "table-responsive");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead class=\"thead-dark\"><tr><th>Name</th>\r\n                <th>Read</th>\r\n                <th>Edit</th>\r\n                <th>Delete</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 17 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
             foreach (var user in User)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 21 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
                     user.UserFirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
                     user.UserLastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/user/details/" + (
#nullable restore
#line 27 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
                                            user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/user/update/" + (
#nullable restore
#line 30 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
                                           user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/user/delete/" + (
#nullable restore
#line 33 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
                                           user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.AddMarkupContent(29, "<p><a class=\"btn btn-primary\" href=\"/user/create\">Create</a></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\User\List.razor"
       
    private List<User> User = new List<User>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            User = await Http.GetFromJsonAsync<List<User>>("/api/Users");
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
