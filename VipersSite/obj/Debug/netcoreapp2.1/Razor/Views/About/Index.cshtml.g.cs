#pragma checksum "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97ea6f4b85c29f8f2f2e35d9b6a7ec64f28a7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d97ea6f4b85c29f8f2f2e35d9b6a7ec64f28a7a1", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1446b58f3b7e00a8812823b9edbf5bc64d52fe0", @"/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Abo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\About\Index.cshtml"
  
    ViewBag.Title = "О нас — Королевская кобра";

#line default
#line hidden
            BeginContext(84, 281, true);
            WriteLiteral(@"
<div class=""row text-center header animate-in"" data-anim-type=""fade-in-up"">
    <div class=""head-title col-xs-12 col-sm-12 col-md-12 col-lg-12"">
        <h3>О нашем магазине</h3>
    </div>
</div>

<div class=""guide-block"">
    <div class=""flex-newsbody"" >
        <h4>
");
            EndContext();
#line 16 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\About\Index.cshtml"
             foreach (var abo in Model)
            {
                

#line default
#line hidden
            BeginContext(438, 26, false);
#line 18 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\About\Index.cshtml"
           Write(Html.Raw(@abo.Description));

#line default
#line hidden
            EndContext();
#line 18 "C:\Users\danic\Desktop\Курсовые 2020-2021\Мои\АИС Ювелирный салон\Окончательное\Исходная работа\VipersSite\Views\About\Index.cshtml"
                                           
            }

#line default
#line hidden
            BeginContext(481, 35, true);
            WriteLiteral("        </h4>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Abo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
