#pragma checksum "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c25129cd73a3bd3018be24506f286d8ef9f0091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
using Kendo.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25129cd73a3bd3018be24506f286d8ef9f0091", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213d235ffd750fcf9d994ac3ae876b82ffaa3f66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Входящие документы";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</br>\r\n\r\n</br>\r\n</br>\r\n\r\n<div class=\"div_tabstrip\">\r\n    ");
#nullable restore
#line 16 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
Write(Html.Kendo().TabStrip()
          .Name("tabstrip")

          .Animation(animation =>
              animation.Open(effect =>
                  effect.Fade(FadeDirection.In)))
          .Items(tabstrip =>
          {
              tabstrip.Add().Text("Калькулятор")
                  .Selected(true)
                  .Content
                  (item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                       ");
#nullable restore
#line 28 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
                   Write(Html.Kendo().DropDownList()
                      .Name("color")
                      .DataTextField("Text")
                      .DataValueField("Value")
                      .Events(e => e.Change("change"))
                      .BindTo(new List<SelectListItem>() {
                          new SelectListItem() {
                              Text = "Black",
                              Value = "1"
                          },
                          new SelectListItem() {
                              Text = "Orange",
                              Value = "2"
                          },
                          new SelectListItem() {
                              Text = "Grey",
                              Value = "3"
                          }
                      })
                      .Value("1")
                      .HtmlAttributes(new { style = "width: 100%" })
                      );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n                  ");
    PopWriter();
}
));

              tabstrip.Add().Text("Отслежнивание")
                  .Content(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral(@"
                    <div class=""weather"">
                        <h2>29<span>&ordm;C</span></h2>
                        <p>Sunny weather in New York.</p>
                    </div>
                    <span class=""sunny"">&nbsp;</span>
                  ");
    PopWriter();
}
));



          })
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<style>\r\n    .div_tabstrip\r\n    {\r\n        width:35%;\r\n        float:right;\r\n    }\r\n    #cap {\r\n        width: 242px;\r\n        height: 225px;\r\n        margin: 20px auto;\r\n        background-image: url(\'");
#nullable restore
#line 79 "C:\Users\Aziz.Nortozhiev\source\repos\Transport\Transport\Views\Home\Index.cshtml"
                          Write(Url.Content("~/shared/web/dropdownlist/cap.png"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        background-repeat: no-repeat;
        background-color: transparent;
    }
    .black-cap {
        background-position: 0 0;
    }
    .grey-cap {
        background-position: 0 -225px;
    }
    .orange-cap {
        background-position: 0 -450px;
    }
</style>


<script>
    function change() {
        var value = $(""#color"").val();
        $(""#cap"")
            .toggleClass(""black-cap"", value == 1)
            .toggleClass(""orange-cap"", value == 2)
            .toggleClass(""grey-cap"", value == 3);
    };


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
