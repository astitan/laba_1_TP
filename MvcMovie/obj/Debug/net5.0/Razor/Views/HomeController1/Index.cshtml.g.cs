#pragma checksum "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf09d4267f34c48ef17a261b355941e74cf69ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeController1_Index), @"mvc.1.0.view", @"/Views/HomeController1/Index.cshtml")]
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
#line 1 "D:\проги\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\проги\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf09d4267f34c48ef17a261b355941e74cf69ff", @"/Views/HomeController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Class>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("main", async() => {
                WriteLiteral("\r\n    <h2>Калькулятор</h2>\r\n    <div class=\"calc\">\r\n");
#nullable restore
#line 13 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
         using (Html.BeginForm())
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.LabelFor(x => x.first_oper, "Первое число: "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.TextBoxFor(x => x.first_oper, new { @class = "textBoxStyle" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.first_oper, "", new { @class = ".errormessagestyle" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p> </p>\r\n");
#nullable restore
#line 20 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.LabelFor(x => x.first_oper, "Второе число: "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.TextBoxFor(x => x.second_oper, new { @class = "textBoxStyle" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.second_oper, "", new { @class = ".errormessagestyle" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>Операция: ");
#nullable restore
#line 23 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
                    Write(Html.DropDownList("act", new MultiSelectList(new string[] { "/", "-", "+", "*" }), new { @class = "operator" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("            <p>Результат:  ");
#nullable restore
#line 25 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
                      Write(Model.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("            <input class=\"button\" type=\"submit\" name=\"click\" value=\"calculate\" />\r\n            <input class=\"button\" type=\"submit\" name=\"click\" value=\"clear\" />\r\n");
#nullable restore
#line 29 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 34 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
Write(Html.ActionLink("Ссылка на вашу операцию", "Urav", new { fir_op = Model.first_oper, sec_op = Model.second_oper, op = Model.act, res = Model.result }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p> </p>\r\n    <h2>Сравнение:</h2>\r\n\r\n");
#nullable restore
#line 38 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
     if (ViewBag.chis != ' ' && Model.second_oper != 0 && Model.second_oper > 0 && Model.second_oper < 100)
    {
        if (Model.result == ViewBag.chis)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral(" Полученное число ");
#nullable restore
#line 42 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
                           Write(Model.result);

#line default
#line hidden
#nullable disable
                WriteLiteral(" равно заданному числу 17\r\n");
#nullable restore
#line 43 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral(" Полученное число ");
#nullable restore
#line 46 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
                           Write(Model.result);

#line default
#line hidden
#nullable disable
                WriteLiteral(" не равно заданному числу 17\r\n");
#nullable restore
#line 47 "D:\проги\MvcMovie\MvcMovie\Views\HomeController1\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <style>
        .textBoxStyle {
            border: 1px solid #ccc;
            padding: 4px;
            font-size: 17px;
        }

        .errormessagestyle {
            color: red;
        }


        .operator {
            border: 1px solid #ccc;
            padding: 6px;
            font-size: 25px;
        }

        body {
            line-height: 2;
            position: relative;
            text-align: center;
        }
    </style>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Class> Html { get; private set; }
    }
}
#pragma warning restore 1591
