#pragma checksum "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990aec49812bdc403d9d4a74ca632744d2ee8892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Edit.cshtml", typeof(AspNetCore.Views_Students_Edit))]
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
#line 1 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\_ViewImports.cshtml"
using CET322_HW1;

#line default
#line hidden
#line 2 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\_ViewImports.cshtml"
using CET322_HW1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990aec49812bdc403d9d4a74ca632744d2ee8892", @"/Views/Students/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d12975a8d129ce375f043734638e875cde65721", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
  
    ViewData["Title"] = "Edit ";

#line default
#line hidden
            BeginContext(57, 21, true);
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(113, 23, false);
#line 11 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(140, 74, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>StudentModel</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(215, 64, false);
#line 16 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(279, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(286, 33, false);
#line 17 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(319, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(362, 93, false);
#line 20 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(455, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(503, 93, false);
#line 22 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(596, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(611, 82, false);
#line 23 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(693, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(764, 96, false);
#line 28 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.LabelFor(model => model.Surname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(908, 96, false);
#line 30 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.EditorFor(model => model.Surname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1019, 85, false);
#line 31 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1175, 94, false);
#line 36 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1317, 94, false);
#line 38 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1426, 83, false);
#line 39 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1580, 32, false);
#line 44 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.LabelFor(m => m.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1623, 664, false);
#line 45 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.DropDownListFor(m => m.DepartmentId, // 1. Store selected value in Model.State;
                                            // when page is rendered after postback,
                                            // take selected value from Model.State.

                              // 2. Take list of values from Model.States
                              Model.departments,

                              // 3. Text for the first 'default' option
                              "- Please select a department -",

                              //4. A class name to assign to <select> tag
                              new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 205, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 65 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(2495, 27, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(2523, 40, false);
#line 71 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Edit.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2563, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591