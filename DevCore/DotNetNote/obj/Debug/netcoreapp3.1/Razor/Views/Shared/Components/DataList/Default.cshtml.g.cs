#pragma checksum "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611d76458b88efcd7bc03ac93f31c1f508274b23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DataList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DataList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/DataList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_DataList_Default))]
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
#line 1 "C:\JYStudy\DevCore\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote;

#line default
#line hidden
#line 1 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
using DotNetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611d76458b88efcd7bc03ac93f31c1f508274b23", @"/Views/Shared/Components/DataList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daafac8a85ee43e3c34bc74f0c87c74269b2818", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DataList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 12, true);
            WriteLiteral("\r\n    <ul>\r\n");
            EndContext();
#line 5 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
     foreach(var data in Model)
    {

#line default
#line hidden
            BeginContext(104, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(117, 7, false);
#line 7 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
       Write(data.Id);

#line default
#line hidden
            EndContext();
            BeginContext(124, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(127, 9, false);
#line 7 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
                 Write(data.Name);

#line default
#line hidden
            EndContext();
            BeginContext(136, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(139, 10, false);
#line 7 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
                             Write(data.Title);

#line default
#line hidden
            EndContext();
            BeginContext(149, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 8 "C:\JYStudy\DevCore\DotNetNote\Views\Shared\Components\DataList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(163, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data>> Html { get; private set; }
    }
}
#pragma warning restore 1591