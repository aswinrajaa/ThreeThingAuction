#pragma checksum "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca697f45c534cf7d61d5adbaa0f215b35dca6773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Event), @"mvc.1.0.view", @"/Views/Events/Event.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Event.cshtml", typeof(AspNetCore.Views_Events_Event))]
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
#line 1 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\_ViewImports.cshtml"
using ThreeThingAuction;

#line default
#line hidden
#line 2 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\_ViewImports.cshtml"
using ThreeThingAuction.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca697f45c534cf7d61d5adbaa0f215b35dca6773", @"/Views/Events/Event.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19aa9a6a5a076449dde1ad0451c941a56d32ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Event : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThreeThingAuction.Models.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Things", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(54, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
  
    ViewData["Title"] = "Event";

#line default
#line hidden
            BeginContext(99, 245, true);
            WriteLiteral("\r\n<h2>Event</h2>\r\n\r\n\r\n\r\n    <h4>Event</h4>\r\n\r\n<table>\r\n    <thead class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th></th>\r\n            <th>Id</th>\r\n            <th>ThingList</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(393, 48, true);
            WriteLiteral("        <tr>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(442, 39, false);
#line 29 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(481, 56, true);
            WriteLiteral(";\r\n            </dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(538, 37, false);
#line 32 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(575, 56, true);
            WriteLiteral(";\r\n            </dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(632, 49, false);
#line 35 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThingList.Name));

#line default
#line hidden
            EndContext();
            BeginContext(681, 39, true);
            WriteLiteral(";\r\n            </dt>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 39 "E:\Lectures\Development_Project\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Views\Events\Event.cshtml"
        }

#line default
#line hidden
            BeginContext(731, 42, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<div> \r\n    ");
            EndContext();
            BeginContext(773, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a05d56c95d43a4b7f26193095cf273", async() => {
                BeginContext(795, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(811, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(819, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e35a6a783844ce999702a41652ec63", async() => {
                BeginContext(842, 11, true);
                WriteLiteral("View Things");
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
            BeginContext(857, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThreeThingAuction.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
