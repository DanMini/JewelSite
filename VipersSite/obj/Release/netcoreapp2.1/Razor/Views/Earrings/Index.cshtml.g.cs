#pragma checksum "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c937af615fc7fa2231dcd6ec1c15f1572d3bd35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Earrings_Index), @"mvc.1.0.view", @"/Views/Earrings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Earrings/Index.cshtml", typeof(AspNetCore.Views_Earrings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c937af615fc7fa2231dcd6ec1c15f1572d3bd35", @"/Views/Earrings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1446b58f3b7e00a8812823b9edbf5bc64d52fe0", @"/_ViewImports.cshtml")]
    public class Views_Earrings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EarringViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Earrings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Earring", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
  
    ViewBag.Title = "Серьги — Ювелирный каталог";

#line default
#line hidden
            BeginContext(85, 281, true);
            WriteLiteral(@"
<div class=""row text-center header animate-in"" data-anim-type=""fade-in-up"">
    <div class=""head-title col-xs-12 col-sm-12 col-md-12 col-lg-12"">
        <h3>Серьги</h3>
    </div>
</div>
<div class=""wrapper-category"">
    <div class=""container categories scroll"">
        ");
            EndContext();
            BeginContext(367, 50, false);
#line 14 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
   Write(await Component.InvokeAsync("ShowEarringCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(417, 45, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"wrapper\">\r\n");
            EndContext();
#line 18 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
     foreach (var earring in Model.Earrings)
    {

#line default
#line hidden
            BeginContext(515, 61, true);
            WriteLiteral("    <div id=\"one\" asp-controller=\"Home\" asp-action=\"Earrings\"");
            EndContext();
            BeginWriteAttribute("asp-rout-id", " asp-rout-id=\"", 576, "\"", 601, 1);
#line 20 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
WriteAttributeValue("", 590, earring.Id, 590, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(602, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 21 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
          
            string status = @earring.Availability;
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
            BeginContext(1019, 10, true);
            WriteLiteral("        <p");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1029, "\"", 1049, 2);
            WriteAttributeValue("", 1037, "color:", 1037, 6, true);
#line 33 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
WriteAttributeValue("", 1043, color, 1043, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1050, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1052, 10, false);
#line 33 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
                           Write(wordStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 31, true);
            WriteLiteral("</p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1093, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd4ccf636d645cba8935af5ca2625c0", async() => {
                BeginContext(1202, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1221, 22, false);
#line 36 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
           Write(Html.Raw(earring.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 46, true);
                WriteLiteral("\r\n                <br>\r\n                Цена: ");
                EndContext();
                BeginContext(1290, 13, false);
#line 38 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
                 Write(earring.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1303, 21, true);
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
#line 35 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
                                                                WriteLiteral(earring.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1177, "color:", 1177, 6, true);
#line 35 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
AddHtmlAttributeValue("", 1183, colorDescription, 1183, 17, false);

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
            BeginContext(1328, 28, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Earrings\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1363, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EarringViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
