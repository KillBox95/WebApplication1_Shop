#pragma checksum "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9459dab75b99b07b203b0596569498e575460303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tovars_List), @"mvc.1.0.view", @"/Views/Tovars/List.cshtml")]
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
#line 1 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewsModls;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9459dab75b99b07b203b0596569498e575460303", @"/Views/Tovars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d8f707706e60e2b2b846434ded4fd32303cb7d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tovars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h2>МАГАЗИН САМОРЕЗОВ</h2>\r\n    <h3>");
#nullable restore
#line 2 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
   Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 3 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
      
        foreach (var tovar in Model.AllTovars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card mb-4\" data-id=\"\">\r\n                    <img class=\"product-img\" src=\"img/${item.imgSrc}\"");
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 296, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body text-center\">\r\n                        <h4 class=\"item-title\">");
#nullable restore
#line 10 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
                                          Write(tovar.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p><small data-items-in-box class=\"text-muted\">");
#nullable restore
#line 11 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
                                                                  Write(tovar.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" шт</small></p>
                        <div class=""details-wrapper"">
                            <div class=""items counter-wrapper"">
                                <div class=""items__control"" data-action=""minus"">-</div>
                                <div class=""items__current"" data-counter>1</div>
                                <div class=""items__control"" data-action=""plus"">+</div>
                            </div>
                            <div class=""price__currency"">");
#nullable restore
#line 18 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
                                                    Write(tovar.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <button data-cart type=\"button\" class=\"btn btn-block btn-outline-warning\">+ в корзину</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "F:\УЧЕБА!\Зима 2023\ИИС\WebApplication1\WebApplication1\Views\Tovars\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
