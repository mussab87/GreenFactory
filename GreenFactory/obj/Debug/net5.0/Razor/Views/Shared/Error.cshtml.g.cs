#pragma checksum "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fea4cbeeb5a040508840672920dc7f66e6509a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\_ViewImports.cshtml"
using GreenFactory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\_ViewImports.cshtml"
using GreenFactory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fea4cbeeb5a040508840672920dc7f66e6509a2", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feeed2d78d81a835c628b2715e6cb0400f60b61b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<!-- START PRIMARY -->
<div id=""primary"" class=""sidebar-no"" dir=""rtl"" lang=""ar"">
    <div class=""container group"" dir=""rtl"" lang=""ar"">
        <div class=""row"" dir=""rtl"" lang=""ar"">
            <!-- START CONTENT -->
            <div id=""content-page"" class=""span12 content group"" dir=""rtl"" lang=""ar"">
                <div class=""page type-page status-publish hentry group"" dir=""rtl"" lang=""ar"">
                    <div class=""box error-box"" style=""font-size: 25px;direction: rtl;"">
                        <b>
                             ???????????? ???????? ?????? ?????????? ???????? ???????????????? ???? ?????? ??????
                        </b>
                    </div>

");
#nullable restore
#line 22 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Shared\Error.cshtml"
                     if (Model.ShowRequestId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            <strong>Request ID:</strong> <code>");
#nullable restore
#line 25 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Shared\Error.cshtml"
                                                          Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n                        </p>\r\n");
#nullable restore
#line 27 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Shared\Error.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>                \r\n            </div>\r\n            <!-- END CONTENT -->\r\n            <!-- START EXTRA CONTENT -->\r\n            <!-- END EXTRA CONTENT -->\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- END PRIMARY -->\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
