#pragma checksum "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6c21bc8780393312bbdd1b1c13d8f14eca26a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainHome_Index), @"mvc.1.0.view", @"/Views/MainHome/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6c21bc8780393312bbdd1b1c13d8f14eca26a8", @"/Views/MainHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feeed2d78d81a835c628b2715e6cb0400f60b61b", @"/Views/_ViewImports.cshtml")]
    public class Views_MainHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
  
    Layout = "~/Views/Shared/_Home.cshtml";
    ViewBag.Title = "Home Page";
    //var viewDataMyObj = (ForeignOfficeTbl)ViewData["User"];
    if (ViewData["User"] != null)
    {
        //ViewBag.user = ViewData["User"];
        ////ViewBag.logo = viewDataMyObj.OfficePhoto;
        ////ViewBag.Office_Id = viewDataMyObj.OfficeId;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""breadcrumbs-inner"">
        <div class=""row m-1"">
            <div class=""col-md-12"">
                <div class=""page-header float-left"">
                    <div class=""page-title"">
                        <ol class=""breadcrumb text-left"">
                            <li class=""active""><a href=""#"">Employees Management System: Welcome Back</a></li>
");
#nullable restore
#line 23 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                             if (ViewData["User"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\"><a href=\"#\">");
#nullable restore
#line 25 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                                          Write(ViewData["User"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" User</a></li>\r\n");
#nullable restore
#line 26 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ol>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <br />\r\n");
#nullable restore
#line 43 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
     if (SignInManager.Context.User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""stat-widget-five"">
                        <div class=""stat-icon dib flat-color-4"">
                            <i class=""pe-7s-users""></i>
                        </div>
                        <div class=""stat-content"">
                            <div class=""text-left dib"">
");
#nullable restore
#line 54 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                 if (ViewBag.countAll != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"stat-text\"><span class=\"count\">");
#nullable restore
#line 56 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                                                          Write(ViewBag.countAll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 57 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"stat-text\"><span class=\"count\">0</span></div>\r\n");
#nullable restore
#line 61 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""stat-heading"">Employees</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""stat-widget-five"">
                        <div class=""stat-icon dib flat-color-1"">
                            <i class=""pe-7s-users""></i>
                        </div>
                        <div class=""stat-content"">
                            <div class=""text-left dib"">

");
#nullable restore
#line 80 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                 if (ViewBag.countAllEvaluated != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"stat-text\"><span class=\"count\">");
#nullable restore
#line 82 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                                                          Write(ViewBag.countAllEvaluated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 83 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"stat-text\"><span class=\"count\">0</span></div>\r\n");
#nullable restore
#line 87 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                                <div class=""stat-heading"">Done Evaluation</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 96 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\MainHome\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n<div class=\"clearfix\"></div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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