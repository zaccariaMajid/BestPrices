#pragma checksum "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb2085fdff3eeb69d7b37497d81e6bcbb9de039e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BestPrices.Site.Pages.users.Pages_users_Index), @"mvc.1.0.razor-page", @"/Pages/users/Index.cshtml")]
namespace BestPrices.Site.Pages.users
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
#line 1 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\_ViewImports.cshtml"
using BestPrices.Site;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2085fdff3eeb69d7b37497d81e6bcbb9de039e", @"/Pages/users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4209daa6037a1468a7cbd9c53a637395bec675", @"/Pages/_ViewImports.cshtml")]
    public class Pages_users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/users/register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/users/login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
  
    ViewData["Title"] = "User area";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 7 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb2085fdff3eeb69d7b37497d81e6bcbb9de039e4691", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
     if (Model.User == null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"text-center mt-5\">\r\n            <p>You are not logged in! ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb2085fdff3eeb69d7b37497d81e6bcbb9de039e5280", async() => {
                    WriteLiteral("Register");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" or ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb2085fdff3eeb69d7b37497d81e6bcbb9de039e6499", async() => {
                    WriteLiteral("Log in");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container mt-5\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <p>Username: ");
#nullable restore
#line 22 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
                            Write(Model.User.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <p>Email: ");
#nullable restore
#line 27 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
                         Write(Model.User.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/users/edit""><i class=""bi bi-pencil-square""></i> Edit your data</a>
                </div>
            </div>
            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/users/changepassword""><i class=""bi bi-lock""></i> Change password</a>
                </div>
            </div>
            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/history/""><i class=""bi bi-clock-history""></i> History</a>
                </div>
            </div>
            <div class=""row mt-2"">
                <div class=""col"">
                    <a href=""/favourites/""><i class=""bi bi-heart""></i> Your favourites (");
#nullable restore
#line 47 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"
                                                                                   Write(Model.FavCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")</a>
                </div>
            </div>
            <div class=""row mt-4"">
                <div class=""col-2"">
                    <a href=""/users/login"" class=""btn btn-outline-danger"">Switch account</a>
                </div>
                <div class=""col-1"">
                </div>
                <div class=""col"">
                    <input type=""submit"" value=""Log out"" class=""btn btn-danger"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 61 "C:\Users\giugg\source\repos\BestPrices\BestPrices.Site\BestPrices.Site\Pages\users\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestPrices.Site.Pages.users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BestPrices.Site.Pages.users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BestPrices.Site.Pages.users.IndexModel>)PageContext?.ViewData;
        public BestPrices.Site.Pages.users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
