#pragma checksum "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adeacf9f7d882909a269427b7278ac5390a07b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#nullable restore
#line 8 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adeacf9f7d882909a269427b7278ac5390a07b89", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756280ea3381528932bb9092039ef22b32237249", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Asus\Desktop\Kamran Lahiye (1)\Kamran Lahiye\Layihe\FinalLayihesi\FinalLayihesi\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";



    string userString = HttpContextAccessor.HttpContext.Session.GetString("ValidUser");
    User user = null;

    if (userString != null)
    {
        user = JsonConvert.DeserializeObject<User>
    (userString);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591