#pragma checksum "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5263023ca67977f7a93f5389b9f412b5ac8255c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BestPrices.Site.Pages.History.Pages_History_Index), @"mvc.1.0.razor-page", @"/Pages/History/Index.cshtml")]
namespace BestPrices.Site.Pages.History
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
#line 1 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\_ViewImports.cshtml"
using BestPrices.Site;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5263023ca67977f7a93f5389b9f412b5ac8255c8", @"/Pages/History/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4209daa6037a1468a7cbd9c53a637395bec675", @"/Pages/_ViewImports.cshtml")]
    public class Pages_History_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
  
    ViewData["Title"] = "History " + Model.User.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <label>Date</label>
        </div>
        <div class=""col-sm-4"">
            <label>Name product</label>
        </div>
        <div class=""col-sm-4"">
            <label>Link</label>
        </div>
    </div>
");
#nullable restore
#line 19 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
     foreach (var p in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <label>");
#nullable restore
#line 23 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
                  Write(p.Date.ToString("G"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <label>");
#nullable restore
#line 26 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
                  Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 792, "", 805, 1);
#nullable restore
#line 29 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
WriteAttributeValue("", 798, p.Link, 798, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Buy now</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\giuggioli.17210\Documents\GitHub\BestPrices\BestPrices.Site\BestPrices.Site\Pages\History\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestPrices.Site.Pages.History.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BestPrices.Site.Pages.History.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BestPrices.Site.Pages.History.IndexModel>)PageContext?.ViewData;
        public BestPrices.Site.Pages.History.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
