#pragma checksum "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23fffaf90bb8038dd2fe1aa794d24b8c5eb9968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bracelets_Index), @"mvc.1.0.view", @"/Views/Bracelets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bracelets/Index.cshtml", typeof(AspNetCore.Views_Bracelets_Index))]
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
#line 1 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\_ViewImports.cshtml"
using VipersSite.Models;

#line default
#line hidden
#line 2 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\_ViewImports.cshtml"
using VipersSite.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23fffaf90bb8038dd2fe1aa794d24b8c5eb9968", @"/Views/Bracelets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1446b58f3b7e00a8812823b9edbf5bc64d52fe0", @"/_ViewImports.cshtml")]
    public class Views_Bracelets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JewelryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bracelets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Jewelry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
  
    ViewBag.Title = "Браслеты — Ювелирный каталог";

#line default
#line hidden
            BeginContext(87, 302, true);
            WriteLiteral(@"
<div class=""row text-center header animate-in"" data-anim-type=""fade-in-up"">
    <div class=""head-title col-xs-12 col-sm-12 col-md-12 col-lg-12"">
        <h3>Браслеты</h3>
    </div>
</div>
<div class=""wrapper-category"">
    <div class=""container categories scroll"">
        <div>
            ");
            EndContext();
            BeginContext(389, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "320a5b4f5aaf4b5aa8921c837dd6cc3d", async() => {
                BeginContext(438, 12, true);
                WriteLiteral("Все браслеты");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(469, 43, false);
#line 16 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
       Write(await Component.InvokeAsync("ShowCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(512, 61, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"wrapper\">\r\n");
            EndContext();
#line 21 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
     foreach (var jewelry in Model.Jewelries)
    {
        

#line default
#line hidden
#line 23 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
         if (@jewelry.Branch == "Браслеты")
        {

#line default
#line hidden
            BeginContext(683, 70, true);
            WriteLiteral("            <div id=\"one\" asp-controller=\"Home\" asp-action=\"Jewelries\"");
            EndContext();
            BeginWriteAttribute("asp-rout-id", " asp-rout-id=\"", 753, "\"", 778, 1);
#line 25 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
WriteAttributeValue("", 767, jewelry.Id, 767, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(779, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                  
                    string status = jewelry.Availability;
                    string color = "lightblue";
                    string colorDescription = "white";
                    string wordStatus = "В наличии";
                    if (status == "Нет в наличии")
                    {
                        color = "#CDCDCD";
                        colorDescription = "#CDCDCD";
                        wordStatus = "Нет в наличии";
                    }
                

#line default
#line hidden
            BeginContext(1291, 18, true);
            WriteLiteral("                <p");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1309, "\"", 1329, 2);
            WriteAttributeValue("", 1317, "color:", 1317, 6, true);
#line 38 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
WriteAttributeValue("", 1323, color, 1323, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1330, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1332, 10, false);
#line 38 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                                   Write(wordStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 47, true);
            WriteLiteral("</p>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1389, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae4cd931aa3479a828d2826c19c5fb1", async() => {
                BeginContext(1499, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1526, 22, false);
#line 41 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                   Write(Html.Raw(jewelry.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1548, 62, true);
                WriteLiteral("\r\n                        <br>\r\n                        Цена: ");
                EndContext();
                BeginContext(1611, 13, false);
#line 43 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                         Write(jewelry.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1624, 29, true);
                WriteLiteral(" рублей\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                                                                         WriteLiteral(jewelry.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1474, "color:", 1474, 6, true);
#line 40 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
AddHtmlAttributeValue("", 1480, colorDescription, 1480, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1657, 44, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n");
            EndContext();
#line 47 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
        }

#line default
#line hidden
#line 47 "C:\Users\danic\Downloads\Telegram Desktop\Миниахметов_ДР_ПриС-301(инд)\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1719, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JewelryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
