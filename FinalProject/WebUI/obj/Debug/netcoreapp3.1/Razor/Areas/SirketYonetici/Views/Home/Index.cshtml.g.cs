#pragma checksum "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eebd4fbc6d7a0f366f10402ed0667ebff77dbe09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SirketYonetici_Views_Home_Index), @"mvc.1.0.view", @"/Areas/SirketYonetici/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using Entities.Concrete.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebd4fbc6d7a0f366f10402ed0667ebff77dbe09", @"/Areas/SirketYonetici/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79a8ff6601846e773eb80c86c5a0f2937b299d", @"/Areas/SirketYonetici/Views/_ViewImports.cshtml")]
    public class Areas_SirketYonetici_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Yonetici Paneli</h2>\r\n\r\n\r\n<div class=\"container col-6\">\r\n    ");
#nullable restore
#line 10 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("CalisanDogumGunu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Areas\SirketYonetici\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("ResmiTatilKutlama"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
