#pragma checksum "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21998326ee86338da06b56305bcac9ec6dd8f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_ViewEmails), @"mvc.1.0.view", @"/Views/Email/ViewEmails.cshtml")]
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
#line 1 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\_ViewImports.cshtml"
using ClarityEmailer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\_ViewImports.cshtml"
using ClarityEmailer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\_ViewImports.cshtml"
using Emailer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21998326ee86338da06b56305bcac9ec6dd8f76", @"/Views/Email/ViewEmails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ef4bb6b933546405508631f61a74dae9d56d92", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Email_ViewEmails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmailModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearEmails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
  
    ViewBag.Title = "View email sending log";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 6 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<p>This is the log of your email sending. Failures will be reattempted up to three times.</p>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Status</th>
            <th>Timestamp</th>
            <th>Recipient</th>
            <th>Subject</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"5\">There are no records.</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
        }else{
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
             foreach(var email in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
                   Write(email.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
                   Write(email.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
                   Write(email.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
                   Write(email.Recipient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
                   Write(email.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\kevin\Desktop\coding\dotNET junk\ClarityEmailer\ClarityEmailer\Views\Email\ViewEmails.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c21998326ee86338da06b56305bcac9ec6dd8f767494", async() => {
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn-danger\">Clear records</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmailModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
