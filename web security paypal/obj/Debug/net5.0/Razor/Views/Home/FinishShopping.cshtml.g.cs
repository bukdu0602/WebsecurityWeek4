#pragma checksum "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b421129a4c4f7007ec49e82d17c357cf0a21318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FinishShopping), @"mvc.1.0.view", @"/Views/Home/FinishShopping.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\_ViewImports.cshtml"
using web_security_paypal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\_ViewImports.cshtml"
using web_security_paypal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b421129a4c4f7007ec49e82d17c357cf0a21318", @"/Views/Home/FinishShopping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e26ccddca43e09c15ec741447fd8bbbd8ccea80a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FinishShopping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_security_paypal.Data.IPN>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
  
    ViewData["Title"] = "FinishShopping";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FinishShopping</h1>\r\n\r\n<div>\r\n    <h4>IPN</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.custom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.custom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.cart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.cart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.create_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.create_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerMiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerMiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.payerStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.payerStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.paymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.paymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.paymentState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.paymentState));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayNameFor(model => model.finalAmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
       Write(Html.DisplayFor(model => model.finalAmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b421129a4c4f7007ec49e82d17c357cf0a2131818462", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\lnh06\OneDrive - nluva.com\BCIT SSD Program\Visual studio projects\web security paypal\web security paypal\Views\Home\FinishShopping.cshtml"
                           WriteLiteral(Model.paymentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b421129a4c4f7007ec49e82d17c357cf0a2131820682", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web_security_paypal.Data.IPN> Html { get; private set; }
    }
}
#pragma warning restore 1591
