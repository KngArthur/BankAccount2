#pragma checksum "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522df47567804c15e3436fcd806353a47fd37c89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\_ViewImports.cshtml"
using BankAccount.TravelExperts.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\_ViewImports.cshtml"
using BankAccount.TravelExperts.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522df47567804c15e3436fcd806353a47fd37c89", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1d73fc9c910bbd2aaf686942f68125f078b14f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankAccount.TravelExperts.Data.Domain.Customers>
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
#line 3 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustProv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustProv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustPostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustPostal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustHomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustHomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustBusPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustBusPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.AgentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522df47567804c15e3436fcd806353a47fd37c8912901", async() => {
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
#line 82 "C:\Users\mabservi\source\repos\BankAccount\Workshop5\BankAccount.TravelExperts\BankAccount.TravelExperts.WebApp\Views\Customers\Details.cshtml"
                           WriteLiteral(Model.CustomerId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522df47567804c15e3436fcd806353a47fd37c8915115", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankAccount.TravelExperts.Data.Domain.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591
