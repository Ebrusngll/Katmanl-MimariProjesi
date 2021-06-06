#pragma checksum "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b956cec12586e09f18690d88f5f08683ec85fd30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Izin_IzinGorutulemePage), @"mvc.1.0.view", @"/Views/Izin/IzinGorutulemePage.cshtml")]
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
#line 1 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\_ViewImports.cshtml"
using Entities.Concrete.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b956cec12586e09f18690d88f5f08683ec85fd30", @"/Views/Izin/IzinGorutulemePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79a8ff6601846e773eb80c86c5a0f2937b299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Izin_IzinGorutulemePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Concrete.Izin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
  
	ViewData["Title"] = "IzinGorutulemePage";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""Bootstrap4/css/bootstrap.min.css"" rel=""stylesheet"" />

<style>
	.marginleft {
		margin-left: 335px;
	}
</style>
<div class=""row"">
	<div class=""col"">
		<div class=""card"">
			<div class=""card-body"">
				<h5 class=""card-title"">İzinlerim</h5>
				<table class=""table"">
					<thead>
						<tr>
							
							<th scope=""col"">Başlangıç</th>
							<th scope=""col"">Bitiş</th>							
							<th scope=""col"">İzin Türü</th>
							<th scope=""col"">Açıklama</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 30 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
                         foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
                               Write(Html.DisplayFor(a => item.BaslangicTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
                               Write(Html.DisplayFor(a => item.MesaiBaslangicTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
                               Write(Html.DisplayFor(a => item.IzinTanimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
                               Write(Html.DisplayFor(a => item.IzinDetayTalebi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 38 "C:\Users\Ebrus\source\repos\FinalProject\WebUI\Views\Izin\IzinGorutulemePage.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					</tbody>
				</table>
			</div>
		</div>
	</div>

</div>
<script src=""Bootstrap4/js/bootstrap.min.js""></script>
<script>
		$(document).ready(function () {
			$('.leftmenutrigger').on('click', function (e) {
				$('.side-nav').toggleClass(""open"");
				e.preventDefault();
			});
		});
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Concrete.Izin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
