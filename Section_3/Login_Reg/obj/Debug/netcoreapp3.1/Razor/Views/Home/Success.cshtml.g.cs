#pragma checksum "C:\Dojo_Assignments\C#\Section_3\Login_Reg\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9471dd41e33098e1788104076dd00b388bcce194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Dojo_Assignments\C#\Section_3\Login_Reg\Views\_ViewImports.cshtml"
using Login_Reg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dojo_Assignments\C#\Section_3\Login_Reg\Views\_ViewImports.cshtml"
using Login_Reg.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dojo_Assignments\C#\Section_3\Login_Reg\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9471dd41e33098e1788104076dd00b388bcce194", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d854adc586d579a821585c3b71471e0bafa242", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Success</h1>\r\n<h1>");
#nullable restore
#line 3 "C:\Dojo_Assignments\C#\Section_3\Login_Reg\Views\Home\Success.cshtml"
Write(Context.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n <a href=\"/LogOut\">LogOut</a>");
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
