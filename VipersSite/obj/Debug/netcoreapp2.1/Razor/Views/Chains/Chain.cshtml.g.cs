#pragma checksum "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "940c6e140f86a01d2a16771e9b9406c6156609fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chains_Chain), @"mvc.1.0.view", @"/Views/Chains/Chain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chains/Chain.cshtml", typeof(AspNetCore.Views_Chains_Chain))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940c6e140f86a01d2a16771e9b9406c6156609fb", @"/Views/Chains/Chain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1446b58f3b7e00a8812823b9edbf5bc64d52fe0", @"/_ViewImports.cshtml")]
    public class Views_Chains_Chain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chain>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newshover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chains", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
  
        ViewBag.Title = @Model.Name + " — Ювелирный каталог";       

#line default
#line hidden
            BeginContext(93, 159, true);
            WriteLiteral("\r\n<div class=\"guide-block\" style=\"margin-top: 150px;\">\r\n    <div class=\"flex-container\">\r\n        <div class=\"categoryInfo\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(252, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0882ea9ac90446f997087e54b05ae748", async() => {
                BeginContext(326, 8, true);
                WriteLiteral("Все цепи");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(338, 5, true);
            WriteLiteral(" — <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 343, "\"", 407, 2);
            WriteAttributeValue("", 350, "http://ss-team.ru/Bracelets?category=", 350, 37, true);
#line 11 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
WriteAttributeValue("", 387, Model.ChainCategory, 387, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(408, 17, true);
            WriteLiteral(">Цепи категории «");
            EndContext();
            BeginContext(426, 19, false);
#line 11 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
                                                                                                                                                                                        Write(Model.ChainCategory);

#line default
#line hidden
            EndContext();
            BeginContext(445, 143, true);
            WriteLiteral("»</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <div class=\"flex-container\">\r\n        <div class=\"DescInfo\">\r\n            <p>Артикул: ");
            EndContext();
            BeginContext(589, 16, false);
#line 17 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
                   Write(Model.VendorCode);

#line default
#line hidden
            EndContext();
            BeginContext(605, 27, true);
            WriteLiteral("</p>\r\n            <p>Цена: ");
            EndContext();
            BeginContext(633, 11, false);
#line 18 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
                Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(644, 28, true);
            WriteLiteral(" рублей</p>\r\n            <p>");
            EndContext();
            BeginContext(673, 18, false);
#line 19 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
          Write(Model.Availability);

#line default
#line hidden
            EndContext();
            BeginContext(691, 56, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"nameInfo\"><h1>");
            EndContext();
            BeginContext(748, 10, false);
#line 21 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(758, 66, true);
            WriteLiteral("</h1></div>\r\n    </div>\r\n    <div class=\"fullinfo\">\r\n        <div>");
            EndContext();
            BeginContext(825, 20, false);
#line 24 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\Chains\Chain.cshtml"
        Write(Html.Raw(Model.Info));

#line default
#line hidden
            EndContext();
            BeginContext(845, 30, true);
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chain> Html { get; private set; }
    }
}
#pragma warning restore 1591
