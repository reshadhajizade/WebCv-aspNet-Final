#pragma checksum "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfBio\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6097d6ec445996d7e135e46b2f8ad295b956ab28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PdfBio_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PdfBio/Default.cshtml")]
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
#line 3 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using WebCv.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6097d6ec445996d7e135e46b2f8ad295b956ab28", @"/Views/Shared/Components/PdfBio/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42301bcfb8abef73339de8bdadcd081b24592e5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PdfBio_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeBio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 3 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Views\Shared\Components\PdfBio\Default.cshtml"
Write(Model.Text.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeBio> Html { get; private set; }
    }
}
#pragma warning restore 1591