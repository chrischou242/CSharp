#pragma checksum "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e9e1606367fcfb9ef29ae94da1c1b6317c13b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthorPage), @"mvc.1.0.view", @"/Views/Home/AuthorPage.cshtml")]
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
#line 1 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\_ViewImports.cshtml"
using Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\_ViewImports.cshtml"
using Crud.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e9e1606367fcfb9ef29ae94da1c1b6317c13b6", @"/Views/Home/AuthorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a1c165790977d2702e9dcdae67dc632f4b4fe3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"text-center\">\r\n        Welcome to ");
#nullable restore
#line 5 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
              Write(Model.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s page (Member since ");
#nullable restore
#line 5 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                                                     Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n    </h2>\r\n\r\n    <p class.text-center>\r\n        Member since: ");
#nullable restore
#line 9 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                 Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Total Posts: ");
#nullable restore
#line 9 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                                                 Write(Model.Posts.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 12 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
     foreach(Post post in Model.Posts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card shadow p-3 rounded\">\r\n        <h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e9e1606367fcfb9ef29ae94da1c1b6317c13b65265", async() => {
#nullable restore
#line 16 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                                                                                     Write(post.Topic);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PostId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                                                                WriteLiteral(post.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PostId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PostId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PostId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 19 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
       Write(post.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 558, "\"", 576, 1);
#nullable restore
#line 21 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
WriteAttributeValue("", 564, post.ImgUrl, 564, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Post\">\r\n        <small class=\"text-muted\">\r\n            submitted: ");
#nullable restore
#line 23 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
                  Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </small>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Dojo_Assignments\C#\Section_3\Crud\Views\Home\AuthorPage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
