#pragma checksum "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_AutLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65dcd5d8add58c7a7406f16c5317bb4103820458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AutLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AutLayout.cshtml")]
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
#line 1 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_ViewImports.cshtml"
using Project2.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_ViewImports.cshtml"
using Project2.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_ViewImports.cshtml"
using Project2.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65dcd5d8add58c7a7406f16c5317bb4103820458", @"/Areas/Identity/Pages/_AutLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4008bd627012606a690177e1d6fe8cccd5c2ca29", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AutLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_AutLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>Sign In</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'>Sign Up</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 21 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_AutLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 31 "E:\Final year\sem2\CMPG 323\project 2\software\32040776_Project2\Project2\Project2\Areas\Identity\Pages\_AutLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<script>
    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
</script>
");
            }
            );
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
