#pragma checksum "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53030d82a6ceaf81518f36c757f6cf3d7287511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Details.cshtml", typeof(AspNetCore.Views_Employee_Details))]
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
#line 1 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\_ViewImports.cshtml"
using labQuiz_TARATHEP_ORA03_NETCore;

#line default
#line hidden
#line 2 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\_ViewImports.cshtml"
using labQuiz_TARATHEP_ORA03_NETCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53030d82a6ceaf81518f36c757f6cf3d7287511", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d5d9b12769405af60f878bec5d210365fcf50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<labQuiz_TARATHEP_ORA03_NETCore.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(95, 133, true);
            WriteLiteral("\r\n<h2>Employee Details</h2>\r\n\r\n<div>\r\n    <h4>employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(229, 41, false);
#line 14 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.empNo));

#line default
#line hidden
            EndContext();
            BeginContext(270, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(316, 37, false);
#line 18 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.empNo));

#line default
#line hidden
            EndContext();
            BeginContext(353, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(399, 45, false);
#line 22 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.titleName));

#line default
#line hidden
            EndContext();
            BeginContext(444, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(490, 41, false);
#line 26 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.titleName));

#line default
#line hidden
            EndContext();
            BeginContext(531, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(577, 45, false);
#line 30 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(622, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(668, 41, false);
#line 34 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(709, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 44, false);
#line 38 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(799, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 40, false);
#line 42 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(885, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(931, 42, false);
#line 46 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(973, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1019, 38, false);
#line 50 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1103, 46, false);
#line 54 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1195, 42, false);
#line 58 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1283, 42, false);
#line 62 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1371, 38, false);
#line 66 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1457, 57, false);
#line 72 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.empNo }));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1523, 40, false);
#line 73 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<labQuiz_TARATHEP_ORA03_NETCore.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
