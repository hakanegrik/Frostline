#pragma checksum "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e02d80e201c86858a48660015f4086b8184ff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/_ViewImports.cshtml"
using FrostlineECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
using FrostlineECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e02d80e201c86858a48660015f4086b8184ff2", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95703e55755bcf124f07ca8f2fb0a0be0ba473a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n\n");
#nullable restore
#line 8 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
 foreach (var item in Model.Period)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"btn btn-outline-primary\">\n      \n            <a");
            BeginWriteAttribute("href", " href=\"", 151, "\"", 192, 2);
            WriteAttributeValue("", 158, "/Product/DiscountProducts/", 158, 26, true);
#nullable restore
#line 11 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
WriteAttributeValue("", 184, item.Id, 184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-btn-warning\">");
#nullable restore
#line 11 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n    </div>\n");
#nullable restore
#line 13 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th scope=\"col\">Id</th>\n            <th scope=\"col\">Name</th>\n            <th scope=\"col\">CategoryId</th>\n            <th scope=\"col\">IsActive</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 27 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
         foreach (var item in Model.Product)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 30 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 31 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
               Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 35 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n<a href=\"/Product/Discount/\" class=\"btn-btn-warning\">Discounts Transactions</a>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
