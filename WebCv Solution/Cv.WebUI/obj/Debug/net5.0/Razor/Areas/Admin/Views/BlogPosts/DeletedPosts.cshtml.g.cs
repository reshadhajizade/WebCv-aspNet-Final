#pragma checksum "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52cb8e91aa177199ee1eb39a0ea7db29610464e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPosts_DeletedPosts), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPosts/DeletedPosts.cshtml")]
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
#line 3 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.Business.ProjectCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebCv.Domain.Business.ProjectsModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cb8e91aa177199ee1eb39a0ea7db29610464e2", @"/Areas/Admin/Views/BlogPosts/DeletedPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f54ec1333e1ce73871c3251e72f4117a933525c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogPosts_DeletedPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletedPostDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.customize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
  
    ViewData["Title"] = "DeletedPosts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52cb8e91aa177199ee1eb39a0ea7db29610464e28050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

    <div class=""page-wrapper"">
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-lg-8"">
                    <div class=""page-header-title"">
                        <div class=""d-inline"">
                            <h4>Bootstrap Border Sizes</h4>
                            <span>
                                lorem ipsum dolor sit amet, consectetur adipisicing
                                elit
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""page-header-breadcrumb"">
                        <ul class=""breadcrumb-title"">
                            <li class=""breadcrumb-item"" style=""float: left;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cb8e91aa177199ee1eb39a0ea7db29610464e210170", async() => {
                WriteLiteral(" <i class=\"feather icon-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>

                            <li class=""breadcrumb-item"" style=""float: left;"">
                                <span>BlogPosts</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""page-body"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5>Horizontal Borders</h5>
                    <span>
                        Example of <code>horizontal</code> table borders. This is a
                        default table border style attached to <code>.table</code> class.
                        All borders have the same grey color and style, table itself doesn't
                        have a border, but you can add this border using
                        <code>.table-framed</code> class added to the table with
                        <code>.table</code> class.
                    </span>

  ");
            WriteLiteral(@"              </div>
                <div class=""card-block table-border-style"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>

                                    </th>
                                    <th>
                                        ");
#nullable restore
#line 66 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 78 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"image-cell\">\r\n");
#nullable restore
#line 82 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                         if (!string.IsNullOrWhiteSpace(item.ImagePath))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52cb8e91aa177199ee1eb39a0ea7db29610464e215153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3510, "~/uploads/images/", 3510, 17, true);
#nullable restore
#line 84 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
AddHtmlAttributeValue("", 3527, item.ImagePath, 3527, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 88 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse \">\r\n                                        ");
#nullable restore
#line 91 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(item.Body.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 94 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td class=\"operations table-imaged\">\r\n                                        <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4328, "\"", 4379, 6);
            WriteAttributeValue("", 4338, "removeEntityBack(", 4338, 17, true);
#nullable restore
#line 98 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
WriteAttributeValue("", 4355, item.Id, 4355, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4363, ",", 4363, 1, true);
            WriteAttributeValue(" ", 4364, "\'", 4365, 2, true);
#nullable restore
#line 98 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
WriteAttributeValue("", 4366, item.Title, 4366, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4377, "\')", 4377, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-rotate-left mr-0\"></i></a>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cb8e91aa177199ee1eb39a0ea7db29610464e219468", async() => {
                WriteLiteral("<i class=\"fa-solid fa-eye mr-0\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4672, "\"", 4719, 6);
            WriteAttributeValue("", 4682, "removeEntity(", 4682, 13, true);
#nullable restore
#line 100 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
WriteAttributeValue("", 4695, item.Id, 4695, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4703, ",", 4703, 1, true);
            WriteAttributeValue(" ", 4704, "\'", 4705, 2, true);
#nullable restore
#line 100 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
WriteAttributeValue("", 4706, item.Title, 4706, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4717, "\')", 4717, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash-can mr-0\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 110 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cb8e91aa177199ee1eb39a0ea7db29610464e223621", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cb8e91aa177199ee1eb39a0ea7db29610464e224721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cb8e91aa177199ee1eb39a0ea7db29610464e225821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script class=""removeable"">
        function removeEntity(id, name) {
            swal(`Are you sure you want to delete as permanently ${name}?`, {
                title: ""Diqqet!"",
                text: `Are you sure you want to delete as permanently ${name}?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""No"", ""Yes""]
            })
                .then((value) => {

                    if (value == true) {

                        let vToken = $('[name=__RequestVerificationToken]').val();

                        let formData = new FormData();
                        formData.set('__RequestVerificationToken', vToken);
                        formData.set('id', id);

                        $.ajax({
                            url: `");
#nullable restore
#line 139 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                             Write(Url.Action("Clear"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: 'POST',
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (response) {
                                console.log(response)
                                if (response.error == true) {
                                    toaster.error(response.message, ""Xeta"");
                                    return;
                                }
                                location.reload();
                            },
                            error: function (errorResponse) {
                                console.error(errorResponse);
                            }
                        });
                    }


                });

        }
        function removeEntityBack(id, name) {
            swal(`Are you sure you want to get back ${name}?`, {
                title: ""Diqqet!"",
                tex");
                WriteLiteral(@"t: `Are you sure you want to get back ${name}?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""No"", ""Yes""]
            })
                .then((value) => {

                    if (value == true) {

                        let vToken = $('[name=__RequestVerificationToken]').val();

                        let formData = new FormData();
                        formData.set('__RequestVerificationToken', vToken);
                        formData.set('id', id);

                        $.ajax({
                            url: `");
#nullable restore
#line 182 "C:\Users\hp\Desktop\WebCv Solution\Cv.WebUI\Areas\Admin\Views\BlogPosts\DeletedPosts.cshtml"
                             Write(Url.Action("Back"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: 'POST',
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (response) {
                                console.log(response)
                                if (response.error == true) {
                                    toaster.error(response.message, ""Xeta"");
                                    return;
                                }
                                location.reload();
                            },
                            error: function (errorResponse) {
                                console.error(errorResponse);
                            }
                        });
                    }


                });

        }
    </script>
     ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
