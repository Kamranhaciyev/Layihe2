#pragma checksum "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52433fd8044e5e4bd99fad8af4390da56ac58dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subscriber_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\_ViewImports.cshtml"
using FinalLayihesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\_ViewImports.cshtml"
using FinalLayihesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\_ViewImports.cshtml"
using FinalLayihesi.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52433fd8044e5e4bd99fad8af4390da56ac58dfb", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756280ea3381528932bb9092039ef22b32237249", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subscriber_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FinalLayihesi.Models.Subscriber>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Subscribers</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Email
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 33 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Subscriber\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FinalLayihesi.Models.Subscriber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
