#pragma checksum "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49b9ffa6c43b5acbfcce8e957ce8ab9884b41ad"
// <auto-generated/>
#pragma warning disable 1591
namespace WeatherDataManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using WeatherDataManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using WeatherDataManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\_Imports.razor"
using WeatherDataManagement.Web.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class WeatherdataList : BaseWeatherDataList
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>WeatherdataList</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th scop=\"col\">ID</th>\r\n            <th scop=\"col\">Temp</th>\r\n            <th scop=\"col\">%</th>\r\n            <th scop=\"col\">Date</th>\r\n            <th scop=\"col\">Location</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 16 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
         foreach (var weatherdata in Weatherdatas)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "scope", "row");
            __builder.AddContent(12, 
#nullable restore
#line 19 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
                             weatherdata.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 20 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
                 weatherdata.Temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 21 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
                 weatherdata.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 22 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
                 weatherdata.DateAndTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 23 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
                 weatherdata.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "D:\It-Högskolan\Blazor\blazorTutorial\WeatherDataManagement\Pages\WeatherdataList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
