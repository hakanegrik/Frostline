#pragma checksum "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff9554df4655c71cbd425721e376d77b9336330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DiscountProducts), @"mvc.1.0.view", @"/Views/Product/DiscountProducts.cshtml")]
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
#line 1 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
using FrostlineECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff9554df4655c71cbd425721e376d77b9336330", @"/Views/Product/DiscountProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95703e55755bcf124f07ca8f2fb0a0be0ba473a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DiscountProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n\n");
#nullable restore
#line 8 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
 foreach (var item in Model.Period)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"btn btn-outline-primary\">\n\n        <a");
            BeginWriteAttribute("href", " href=\"", 141, "\"", 182, 2);
            WriteAttributeValue("", 148, "/Product/DiscountProducts/", 148, 26, true);
#nullable restore
#line 11 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
WriteAttributeValue("", 174, item.Id, 174, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-btn-warning\">");
#nullable restore
#line 11 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n    </div>\n");
#nullable restore
#line 13 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"header\">\n    <h1>");
#nullable restore
#line 17 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
   Write(ViewBag.PeriodName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
</div>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">CategoryId</th>
            <th scope=""col"">IsActive</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
         foreach (var item in Model.Product)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 32 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 33 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
               Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 37 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 838, "\"", 886, 2);
            WriteAttributeValue("", 845, "/Product/PeriodDiscount/", 845, 24, true);
#nullable restore
#line 43 "/Users/macbook/Projects/FrostlineECommerce/FrostlineECommerce/Views/Product/DiscountProducts.cshtml"
WriteAttributeValue("", 869, ViewBag.PeriodId, 869, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-btn-warning\">Edit Period </a>");
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