#pragma checksum "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6bf41ce920f8d268c61fbd6491aa537aacc65b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrivateMessages_ViewPM), @"mvc.1.0.view", @"/Views/PrivateMessages/ViewPM.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bf41ce920f8d268c61fbd6491aa537aacc65b4", @"/Views/PrivateMessages/ViewPM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_PrivateMessages_ViewPM : Nop.Web.Framework.Mvc.Razor.NopRazorPage<PrivateMessageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
  
    Layout = "_ColumnsOne";

    //title
    Html.AddTitleParts(T("PageTitle.ViewPM").Text);
    //page class
    Html.AppendPageCssClassParts("html-private-messages");
    Html.AppendPageCssClassParts("html-private-message-view-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page private-messages private-message-view-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 13 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
       Write(T("PrivateMessages.View.ViewMessage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n        <div class=\"view-message\">\r\n            <ul class=\"message-head\">\r\n                <li class=\"sender\">\r\n                    <label>");
#nullable restore
#line 19 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                      Write(T("PrivateMessages.View.From"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <span>");
#nullable restore
#line 20 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                     Write(Model.CustomerFromName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li class=\"recipient\">\r\n                    <label>");
#nullable restore
#line 23 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                      Write(T("PrivateMessages.View.To"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <span>");
#nullable restore
#line 24 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                     Write(Model.CustomerToName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li class=\"subject\">\r\n                    <label>");
#nullable restore
#line 27 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                      Write(T("PrivateMessages.View.Subject"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <span>");
#nullable restore
#line 28 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
                     Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n            </ul>\r\n            <div class=\"message-body\">\r\n                ");
#nullable restore
#line 32 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
           Write(Html.Raw(Model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"buttons\">\r\n            <input type=\"button\" class=\"button-1 reply-pm-button\"");
            BeginWriteAttribute("value", " value=\"", 1330, "\"", 1376, 1);
#nullable restore
#line 36 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1338, T("PrivateMessages.View.ReplyButton"), 1338, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1377, "\"", 1504, 3);
            WriteAttributeValue("", 1387, "setLocation(\'", 1387, 13, true);
#nullable restore
#line 36 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1400, Url.RouteUrl("SendPMReply", new { toCustomerId = Model.FromCustomerId, replyToMessageId = Model.Id }), 1400, 102, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1502, "\')", 1502, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"button\" class=\"button-2 delete-pm-button\"");
            BeginWriteAttribute("value", " value=\"", 1576, "\"", 1623, 1);
#nullable restore
#line 37 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1584, T("PrivateMessages.View.DeleteButton"), 1584, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1624, "\"", 1711, 3);
            WriteAttributeValue("", 1634, "setLocation(\'", 1634, 13, true);
#nullable restore
#line 37 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1647, Url.RouteUrl("DeletePM", new { privateMessageId = Model.Id }), 1647, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1709, "\')", 1709, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"button\" class=\"button-2 back-pm-button\"");
            BeginWriteAttribute("value", " value=\"", 1781, "\"", 1826, 1);
#nullable restore
#line 38 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1789, T("PrivateMessages.View.BackButton"), 1789, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1827, "\"", 1884, 3);
            WriteAttributeValue("", 1837, "setLocation(\'", 1837, 13, true);
#nullable restore
#line 38 "C:\Users\Rodo\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\PrivateMessages\ViewPM.cshtml"
WriteAttributeValue("", 1850, Url.RouteUrl("PrivateMessages"), 1850, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1882, "\')", 1882, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivateMessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
