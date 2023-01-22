// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Coursework2.Client.Pages.Project
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
#line 3 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\Project\Read.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project/details/{ProjectId:guid}")]
    public partial class Read : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\lisan\OneDrive\Desktop\CW2\w1738929\Coursework2\Client\Pages\Project\Read.razor"
       
    [Parameter]
    public Guid ProjectId { get; set; }
    private Project project { get; set; } = new Project();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            project = await Http.GetFromJsonAsync<Project>($"/api/Projects/{ProjectId}");

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
        Navigation.NavigateTo("/project");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
