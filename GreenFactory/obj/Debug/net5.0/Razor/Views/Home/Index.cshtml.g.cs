#pragma checksum "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7311f51d5449de0aec9e527c73a7f5376529cdfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7311f51d5449de0aec9e527c73a7f5376529cdfa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feeed2d78d81a835c628b2715e6cb0400f60b61b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/PaperHome002.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("004"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Green Factory Website\Project\GreenFactory\GreenFactory\Views\Home\Index.cshtml"
   
    ViewBag.slide = "yes";
    ViewBag.title = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- START PRIMARY -->
        <div id=""primary"" class=""sidebar-no"">
            <div class=""container group"">
                <div class=""row"">

                    <!-- START CONTENT -->
                    <div id=""content-home"" class=""span12 content group"">
                        <div class=""page type-page status-publish hentry group"">

                            <script>
                                jQuery(document).ready(function ($) {
                                    $('.sidebar').remove();

                                    if (!$('#primary').hasClass('sidebar-no')) {
                                        $('#primary').removeClass().addClass('sidebar-no');
                                        $('.content').removeClass('span9').addClass('span12');
                                    }

                                });
                            </script>

                            <hr />
                            <div class=""portfolios type-portfolio");
            WriteLiteral(@"s status-publish hentry work group row"">
                                <div class=""work-thumbnail span6"">
                                    <div class=""thumb-wrapper"">
                                        <div class=""work-thumbnail"">
                                            <div class=""picture_overlay_empty picture_overlay"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7311f51d5449de0aec9e527c73a7f5376529cdfa5502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        
                                    </div>
                                </div>

                                <div class=""work-description span6"" dir=""rtl"">
                                    <h1>مرحبا بكم في المصنع الأخضر للمنتجات الورقية</h1>
                                    <p>                                    
                                        اول مصنع للمصاصات الورقية الصديقة للبيئة في المملكة العربية السعودية. نفتخر بإمداد السوق المحلي بمصاصة ورقية بديلة للمصاصة البلاستكية التي لها اضرار على البيئة، الانسان، والمحيطات والبحار.                                        
                                    </p>
                                    <p>
                                        جاءت فكرة المصنع الأخضر للمنتجات الورقية استجابة للحركة المتزايدة بين المستهلكين لتقليل استخدام المواد البلاستيكية خاصة في مصاصات المشروبات الباردة. جمي");
            WriteLiteral(@"ع المواد الخام المستخدمة في صناعة المصاصة الورقية مستوردة من أوروبا، نستورد الورق من شركة متخصصة في صناعة الأوراق.
                                    </p>
                                    
                                    <div></div>

                                   
                                </div>
                                <div class=""clear""></div>
                            </div>

                            <script type=""text/javascript"" charset=""utf-8"">
                                jQuery(document).ready(function ($) {

                                    function isMobile() {
                                        return navigator.userAgent.match(/iPhone/i) || navigator.userAgent.match(/iPod/i) || (navigator.userAgent.match(/Android/i) && navigator.userAgent.match(/Mobile/i));
                                    }


                                    if (!isMobile()) {

                                        $('.open_slide').live('click', function (e) {");
            WriteLiteral(@"
                                            e.preventDefault();

                                            var li_parent = $(this).parents('li');
                                            var div = li_parent.find('.slide_detail');
                                            if (!div.is(':visible')) {
                                                $('.ch-item').removeClass('ch-item-opened');
                                                li_parent.find('.ch-item').addClass('ch-item-opened');

                                                var slide_opened = $('.slide_detail:visible').length;
                                                var same_row = slide_opened && parseInt($('.slide_detail:visible').parents('li').index() / 5) == parseInt($(this).parents('li').index() / 5);
                                                var description_height = div.find('.work-description').height(); console.log(div.find('.work-description'));

                                                var animat");
            WriteLiteral(@"ion = function (div, li_parent, same_row) {
                                                    $.Deferred(function (def) {
                                                        def.pipe(function () {
                                                            return $('ul#portfolio hr, .slide_detail').slideUp(500);
                                                        }).pipe(function () {
                                                            var offset_y = li_parent.data('isotope-item-position') ?
                                                                li_parent.data('isotope-item-position').y + li_parent.offset().top :
                                                                li_parent.offset().top;

                                                            return $.scrollTo(offset_y - 40, same_row ? 1 : 500, { 'axis': 'y' });
                                                        }).pipe(function () {
                                                            return ");
            WriteLiteral(@"setTimeout(function () {
                                                                var offset_x = li_parent.data('isotope-item-position') ?
                                                                    li_parent.data('isotope-item-position').x + li_parent.offset().left :
                                                                    li_parent.offset().left;

                                                                div.css({
                                                                    left: -offset_x + $('#wrapper').offset().left,
                                                                    width: $('#wrapper').width()
                                                                }).slideDown(500);
                                                                $(li_parent).nextAll('hr:first').slideDown(500, function () {
                                                                    //recalculate left offset once the slide is opened
                     ");
            WriteLiteral(@"                                               var offset_x = li_parent.data('isotope-item-position') ?
                                                                        li_parent.data('isotope-item-position').x + li_parent.offset().left :
                                                                        li_parent.offset().left;
                                                                    div.css({
                                                                        left: -offset_x + $('#wrapper').offset().left,
                                                                        width: $('#wrapper').width(),
                                                                        height: div.outerHeight()
                                                                    });

                                                                    $(this).css({
                                                                        height: div.outerHeight()
                    ");
            WriteLiteral(@"                                                });

                                                                    div.find('.container').css({
                                                                        height: div.outerHeight() - 35
                                                                    });
                                                                });
                                                            }, same_row ? 500 : 1000);
                                                        });
                                                    }).resolve();
                                                };
                                                animation(div, li_parent, same_row);
                                            } else {
                                                div.find('.slide_close').click();
                                            }
                                        });

                                        ");
            WriteLiteral(@"$('.slide_close').click(function () {
                                            $('.ch-item').removeClass('ch-item-opened');
                                            $(this).parents('.slide_detail').slideUp('slow');
                                            $('ul#portfolio hr').slideUp('slow');
                                        });

                                        $(window).resize(function () {
                                            if (!isIE8()) {
                                                $('.ch-item').removeClass('ch-item-opened');
                                                $('.slide_detail').slideUp('slow');
                                                $('ul#portfolio hr').slideUp('slow');
                                            }
                                        });


                                    }
                                });
                            </script>

                            <p>&nbsp;</p>

             ");
            WriteLiteral(@"           </div>
                <!-- START COMMENTS -->
                <div id=""comments""></div>
                <!-- END COMMENTS -->
            </div>
            <!-- END CONTENT -->
            <!-- START EXTRA CONTENT -->
            <!-- END EXTRA CONTENT -->

        </div>
   
<!-- END PRIMARY -->

   
</div>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
