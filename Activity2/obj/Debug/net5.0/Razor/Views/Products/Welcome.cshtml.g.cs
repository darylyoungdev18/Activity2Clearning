#pragma checksum "C:\Users\daryl\source\learningrepos\Activity2Clearning\Activity2\Views\Products\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2481d1ce5d567e033c6ceb73d5517f029109772e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Welcome), @"mvc.1.0.view", @"/Views/Products/Welcome.cshtml")]
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
#line 1 "C:\Users\daryl\source\learningrepos\Activity2Clearning\Activity2\Views\_ViewImports.cshtml"
using Activity2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daryl\source\learningrepos\Activity2Clearning\Activity2\Views\_ViewImports.cshtml"
using Activity2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2481d1ce5d567e033c6ceb73d5517f029109772e", @"/Views/Products/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684f1b84bb6b99c11472852475c0380ee592a4ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Welcome ");
#nullable restore
#line 5 "C:\Users\daryl\source\learningrepos\Activity2Clearning\Activity2\Views\Products\Welcome.cshtml"
       Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p> Don\'t tell anyone, but the secret number today is ");
#nullable restore
#line 6 "C:\Users\daryl\source\learningrepos\Activity2Clearning\Activity2\Views\Products\Welcome.cshtml"
                                                 Write(ViewBag.Secret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
