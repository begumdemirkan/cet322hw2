#pragma checksum "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab863a99f176ed23693795e6d1df7524a4ce10e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Add), @"mvc.1.0.view", @"/Views/Students/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Add.cshtml", typeof(AspNetCore.Views_Students_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab863a99f176ed23693795e6d1df7524a4ce10e", @"/Views/Students/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d12975a8d129ce375f043734638e875cde65721", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CET322_HW1.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
  
    ViewData["Title"] = "Add Student";

#line default
#line hidden
            BeginContext(83, 18, true);
            WriteLiteral("\r\n<h1>Add</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(132, 23, false);
#line 11 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(157, 69, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Student</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(227, 64, false);
#line 15 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(291, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(334, 93, false);
#line 18 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(427, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(475, 93, false);
#line 20 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(568, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(583, 82, false);
#line 21 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(665, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(734, 96, false);
#line 25 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.LabelFor(model => model.Surname, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(830, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(878, 96, false);
#line 27 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Surname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(974, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(989, 85, false);
#line 28 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1143, 94, false);
#line 32 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1285, 94, false);
#line 34 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1394, 83, false);
#line 35 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1548, 32, false);
#line 40 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
   Write(Html.LabelFor(m => m.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1591, 664, false);
#line 41 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
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
            BeginContext(2255, 207, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 61 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
}

#line default
#line hidden
            BeginContext(2465, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(2477, 40, false);
#line 63 "C:\Users\Begum\Desktop\Cet322_hw2_begümdemirkan\CET322_HW1\CET322_HW1\Views\Students\Add.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2517, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CET322_HW1.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
