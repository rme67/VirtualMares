#pragma checksum "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Newsletter\SubscriptionActivation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ff346e01e5d7837edc5a013beb8acb928d22c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Newsletter_SubscriptionActivation), @"mvc.1.0.view", @"/Views/Newsletter/SubscriptionActivation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ff346e01e5d7837edc5a013beb8acb928d22c6", @"/Views/Newsletter/SubscriptionActivation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Newsletter_SubscriptionActivation : Nop.Web.Framework.Mvc.Razor.NopRazorPage<SubscriptionActivationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Newsletter\SubscriptionActivation.cshtml"
  
    Layout = "_ColumnsOne";

    //page class
    Html.AppendPageCssClassParts("html-newsletter-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page newsletter-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Newsletter\SubscriptionActivation.cshtml"
       Write(T("Newsletter.Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n        <strong>\r\n            ");
#nullable restore
#line 14 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Newsletter\SubscriptionActivation.cshtml"
       Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </strong>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubscriptionActivationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
