#pragma checksum "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe174831133cb3657489b31b2a639471c91fb47"
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
#line 1 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\_ViewImports.cshtml"
using VipersSite.Models;

#line default
#line hidden
#line 2 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\_ViewImports.cshtml"
using VipersSite.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe174831133cb3657489b31b2a639471c91fb47", @"/Views/Bracelets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1446b58f3b7e00a8812823b9edbf5bc64d52fe0", @"/_ViewImports.cshtml")]
    public class Views_Bracelets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BraceletViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bracelets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Bracelet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
  
    ViewBag.Title = "Браслеты — Ювелирный каталог";

#line default
#line hidden
            BeginContext(88, 283, true);
            WriteLiteral(@"
<div class=""row text-center header animate-in"" data-anim-type=""fade-in-up"">
    <div class=""head-title col-xs-12 col-sm-12 col-md-12 col-lg-12"">
        <h3>Браслеты</h3>
    </div>
</div>
<div class=""wrapper-category"">
    <div class=""container categories scroll"">
        ");
            EndContext();
            BeginContext(372, 51, false);
#line 14 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
   Write(await Component.InvokeAsync("ShowBraceletCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(423, 45, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"wrapper\">\r\n");
            EndContext();
#line 18 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
     foreach (var bracelet in Model.Bracelets)
    {

#line default
#line hidden
            BeginContext(523, 62, true);
            WriteLiteral("    <div id=\"one\" asp-controller=\"Home\" asp-action=\"Bracelets\"");
            EndContext();
            BeginWriteAttribute("asp-rout-id", " asp-rout-id=\"", 585, "\"", 611, 1);
#line 20 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
WriteAttributeValue("", 599, bracelet.Id, 599, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 21 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
          
            string status = bracelet.Availability;
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
            BeginContext(1029, 10, true);
            WriteLiteral("        <p");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1039, "\"", 1059, 2);
            WriteAttributeValue("", 1047, "color:", 1047, 6, true);
#line 33 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
WriteAttributeValue("", 1053, color, 1053, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1060, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1062, 10, false);
#line 33 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                           Write(wordStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 31, true);
            WriteLiteral("</p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1103, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a37f272a36e74d86b6f831b96e9fbdeb", async() => {
                BeginContext(1215, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1234, 23, false);
#line 36 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
           Write(Html.Raw(bracelet.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1257, 46, true);
                WriteLiteral("\r\n                <br>\r\n                Цена: ");
                EndContext();
                BeginContext(1304, 14, false);
#line 38 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                 Write(bracelet.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1318, 21, true);
                WriteLiteral(" рублей\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
                                                                  WriteLiteral(bracelet.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1190, "color:", 1190, 6, true);
#line 35 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
AddHtmlAttributeValue("", 1196, colorDescription, 1196, 17, false);

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
            BeginContext(1343, 28, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Bracelets\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1378, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BraceletViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
