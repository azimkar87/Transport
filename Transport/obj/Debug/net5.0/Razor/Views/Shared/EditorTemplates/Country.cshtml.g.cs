#pragma checksum "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Shared\EditorTemplates\Country.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2566354a93bdb3fb2d02a7873f2a5479db980dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Country), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Country.cshtml")]
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
#line 1 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\_ViewImports.cshtml"
using Transport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2566354a93bdb3fb2d02a7873f2a5479db980dff", @"/Views/Shared/EditorTemplates/Country.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213d235ffd750fcf9d994ac3ae876b82ffaa3f66", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Country : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Shared\EditorTemplates\Country.cshtml"
Write(Html.Kendo().DropDownListFor(m => m)
            .DataValueField("CountryNameShort")
            .DataTextField("CountryNameLong")
            .HtmlAttributes(new { data_bind = "value: Country" })
            .Template(@"<div class='dropdown-country-wrap'><img src='" + @Url.Content("~/content/web/country-flags/#:data.CountryNameShort#.png") + "' alt='#: data.CountryNameLong#' title='#: data.CountryNameLong#' width='20' /><span>#: data.CountryNameLong #</span></div>")
            .BindTo((System.Collections.IEnumerable)ViewData["countries"])
            .AutoWidth(true)
);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
