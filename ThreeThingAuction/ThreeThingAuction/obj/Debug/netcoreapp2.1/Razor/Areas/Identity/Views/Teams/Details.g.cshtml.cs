#pragma checksum "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77efd3b28ba8a38cd909adeb0807239b1afe615e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ThreeThingAuction.Areas.Identity.Pages.Teams.Areas_Identity_Views_Teams_Details), @"mvc.1.0.view", @"/Areas/Identity/Views/Teams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Teams/Details.cshtml", typeof(ThreeThingAuction.Areas.Identity.Pages.Teams.Areas_Identity_Views_Teams_Details))]
namespace ThreeThingAuction.Areas.Identity.Pages.Teams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\_ViewImports.cshtml"
using ThreeThingAuction.Areas.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77efd3b28ba8a38cd909adeb0807239b1afe615e", @"/Areas/Identity/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ebe60423b6d001c31db8380992d12e54a3e242", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThreeThingAuction.Models.Team>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(90, 36, false);
#line 7 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(126, 139, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Team Name:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(266, 36, false);
#line 16 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(302, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Money Assigned:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(404, 37, false);
#line 22 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Money));

#line default
#line hidden
            EndContext();
            BeginContext(441, 109, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Number of Team Members:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(551, 43, false);
#line 28 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoOfMembers));

#line default
#line hidden
            EndContext();
            BeginContext(594, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Team Member 1:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(695, 39, false);
#line 34 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member1));

#line default
#line hidden
            EndContext();
            BeginContext(734, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Team Member 2:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(835, 39, false);
#line 40 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member2));

#line default
#line hidden
            EndContext();
            BeginContext(874, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Team Member 3:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(975, 39, false);
#line 46 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member3));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Team Member 4:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1115, 39, false);
#line 52 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member4));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 57 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
     if (Model.Member1 == User.Identity.Name || Model.Member2 == User.Identity.Name || Model.Member3 == User.Identity.Name || Model.Member4 == User.Identity.Name)
    {

#line default
#line hidden
            BeginContext(1368, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1376, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5980320a9be6495f8bbef6ef498c0460", async() => {
                BeginContext(1423, 5, true);
                WriteLiteral("Leave");
                EndContext();
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
#line 59 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
                                WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1432, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1458, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1466, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43ba5e85a036483ca0a4f0e3250cf0e0", async() => {
                BeginContext(1488, 12, true);
                WriteLiteral("Back to list");
                EndContext();
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
            EndContext();
            BeginContext(1504, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Teams\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1513, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThreeThingAuction.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
