#pragma checksum "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3081ec0e6d263f7664e9510bf2f3b9d73257ed71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResultPage), @"mvc.1.0.view", @"/Views/Home/ResultPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ResultPage.cshtml", typeof(AspNetCore.Views_Home_ResultPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3081ec0e6d263f7664e9510bf2f3b9d73257ed71", @"/Views/Home/ResultPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResultPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyFirstMVCapp.Models.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86b0aad7f2974f0aa8a56ccc293432f7", async() => {
                BeginContext(6, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a98c984bb3f4edab450af278f47f5fa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 11, true);
            WriteLiteral("\r\n<table>\r\n");
            EndContext();
#line 5 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
 foreach (var person in Model)
{

#line default
#line hidden
            BeginContext(168, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(183, 11, false);
#line 8 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(194, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(210, 11, false);
#line 9 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Year);

#line default
#line hidden
            EndContext();
            BeginContext(221, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(237, 14, false);
#line 10 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Context);

#line default
#line hidden
            EndContext();
            BeginContext(251, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(267, 15, false);
#line 11 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Category);

#line default
#line hidden
            EndContext();
            BeginContext(282, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(298, 12, false);
#line 12 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Honor);

#line default
#line hidden
            EndContext();
            BeginContext(310, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(326, 14, false);
#line 13 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Country);

#line default
#line hidden
            EndContext();
            BeginContext(340, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(356, 17, false);
#line 14 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.Birth_Year);

#line default
#line hidden
            EndContext();
            BeginContext(373, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(389, 16, false);
#line 15 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
   Write(person.DeathYear);

#line default
#line hidden
            EndContext();
            BeginContext(405, 16, true);
            WriteLiteral("</td>\r\n\r\n</tr>\r\n");
            EndContext();
#line 18 "C:\Users\Owner\codefellows\401\Lab11-MyFirstMVC\MyFirstMVCapp\Views\Home\ResultPage.cshtml"
    
}

#line default
#line hidden
            BeginContext(430, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(440, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1b1bfdbc2a343d69117f231258778c5", async() => {
                BeginContext(484, 14, true);
                WriteLiteral("Return To Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyFirstMVCapp.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
