#pragma checksum "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a506d3b3ac091de9c9ccc73bc0f47b3dec292b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ThreeThingAuction.Areas.Identity.Pages.Events.Areas_Identity_Views_Events_Index), @"mvc.1.0.view", @"/Areas/Identity/Views/Events/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Events/Index.cshtml", typeof(ThreeThingAuction.Areas.Identity.Pages.Events.Areas_Identity_Views_Events_Index))]
namespace ThreeThingAuction.Areas.Identity.Pages.Events
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a506d3b3ac091de9c9ccc73bc0f47b3dec292b5e", @"/Areas/Identity/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ebe60423b6d001c31db8380992d12e54a3e242", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThreeThingAuction.Models.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 21, true);
            WriteLiteral("<h2>Events</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(151, 90, true);
            WriteLiteral("        <div class=\"card col-sm-4\">\r\n            <h3 class=\"card-title\">\r\n                ");
            EndContext();
            BeginContext(242, 39, false);
#line 14 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(281, 104, true);
            WriteLiteral("\r\n            </h3>\r\n            <p class=\"card-text\">\r\n                Starting Time:\r\n                ");
            EndContext();
            BeginContext(386, 39, false);
#line 18 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(425, 52, true);
            WriteLiteral("<br>\r\n                Ending Time:\r\n                ");
            EndContext();
            BeginContext(478, 42, false);
#line 20 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(520, 42, true);
            WriteLiteral("<br>\r\n                \r\n            </p>\r\n");
            EndContext();
#line 23 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
             if (item.EndDate <= DateTime.Now)
            {

#line default
#line hidden
            BeginContext(625, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(641, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c33ae14f2240f7b56781730509f258", async() => {
                BeginContext(704, 17, true);
                WriteLiteral("The Event is over");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
                                                         WriteLiteral(item.Id);

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
            BeginContext(725, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
            }
            else if (item.Date <= DateTime.Now)
            {

#line default
#line hidden
            BeginContext(806, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(822, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "146a1f22d04348b2b1b1c4f1250eb173", async() => {
                BeginContext(885, 17, true);
                WriteLiteral("Enter the Auction");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
                                                         WriteLiteral(item.Id);

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
            BeginContext(906, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(956, 77, true);
            WriteLiteral("                <a class=\"button startsoon\">The Auction will start soon</a>\r\n");
            EndContext();
#line 34 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1048, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 36 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Events\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThreeThingAuction.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
