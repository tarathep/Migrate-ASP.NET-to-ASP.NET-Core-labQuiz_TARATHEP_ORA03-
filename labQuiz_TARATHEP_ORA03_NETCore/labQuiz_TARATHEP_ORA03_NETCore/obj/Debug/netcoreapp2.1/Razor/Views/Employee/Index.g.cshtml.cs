#pragma checksum "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813f17509ff3843c89519c23469f120cadf2d07f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813f17509ff3843c89519c23469f120cadf2d07f", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d5d9b12769405af60f878bec5d210365fcf50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<labQuiz_TARATHEP_ORA03_NETCore.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(95, 45, true);
            WriteLiteral("\r\n\r\n<h2>Employee List</h2>\r\n\r\n<p>\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(141, 35, false);
#line 14 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(176, 68, true);
            WriteLiteral("\r\n</p>\r\n<table id=\"myTable\" class=\"\">\r\n\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(356, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(391, 45, false);
#line 25 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.titleName));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 45, false);
#line 28 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(537, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(593, 44, false);
#line 31 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(637, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(693, 42, false);
#line 34 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 46, false);
#line 37 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(893, 42, false);
#line 40 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(935, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n    </thead>\r\n");
            EndContext();
            BeginContext(2023, 16, true);
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2056, 181, true);
                WriteLiteral("\r\n    <script>\r\n    $(\"#myTable\").DataTable({\r\n        language: {\r\n            loadingRecords:\"<img src=\'/css/sprinner/loading.gif\'>\"\r\n        },\r\n        ajax:{\r\n            url:\'");
                EndContext();
                BeginContext(2238, 38, false);
#line 85 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
            Write(Url.Action("employeeJson", "Employee"));

#line default
#line hidden
                EndContext();
                BeginContext(2276, 412, true);
                WriteLiteral(@"',
            dataSrc:""""
        },
        columns: [

            { data: ""titleName"" },
            { data: ""firstName"" },
            { data: ""lastName"" },
            { data: ""gender"" },
            { data: ""department"" },
            { data: ""salary"" },
            {
                data: ""empNo"",
                render: function (data) {
                    
                    return '");
                EndContext();
                BeginContext(2689, 53, false);
#line 100 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new {  id = "data" }));

#line default
#line hidden
                EndContext();
                BeginContext(2742, 58, true);
                WriteLiteral("\'.replace(\"data\", data) + \'|\' +\r\n                        \'");
                EndContext();
                BeginContext(2801, 58, false);
#line 101 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
                    Write(Html.ActionLink("Details", "Details", new { id = "data" }));

#line default
#line hidden
                EndContext();
                BeginContext(2859, 58, true);
                WriteLiteral("\'.replace(\"data\", data) + \'|\' +\r\n                        \'");
                EndContext();
                BeginContext(2918, 56, false);
#line 102 "C:\Users\bokee\Desktop\working\labQuiz_TARATHEP_ORA03_NETCore\labQuiz_TARATHEP_ORA03_NETCore\Views\Employee\Index.cshtml"
                    Write(Html.ActionLink("Delete", "Delete", new { id = "data" }));

#line default
#line hidden
                EndContext();
                BeginContext(2974, 103, true);
                WriteLiteral("\'.replace(\"data\", data);\r\n                }\r\n\r\n            }\r\n        ]\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<labQuiz_TARATHEP_ORA03_NETCore.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
