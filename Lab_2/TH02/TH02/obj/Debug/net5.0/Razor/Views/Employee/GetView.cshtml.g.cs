#pragma checksum "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af867996ee40e0e40ddc446f6d4b011495074d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetView), @"mvc.1.0.view", @"/Views/Employee/GetView.cshtml")]
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
#line 1 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\_ViewImports.cshtml"
using TH02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
using TH02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af867996ee40e0e40ddc446f6d4b011495074d9", @"/Views/Employee/GetView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af31f0dbdacfd3a230ef7f9cd43210a3002c5475", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
  
    ViewBag.Title = "GetView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <!--ViewData-->\r\n");
#nullable restore
#line 8 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
      
            Employee employee = (Employee)ViewData["Employee"];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Employee Details</b><br />\r\n    Employee Name: ");
#nullable restore
#line 12 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
              Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
                                  Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Employee Salary: ");
#nullable restore
#line 13 "D:\DotnetArea\ThucHanh\Lab_2\TH02\TH02\Views\Employee\GetView.cshtml"
                Write(employee.Salary.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--ViewBag-->\r\n");
            WriteLiteral("</div>\r\n\r\n<!--Strongly-Typed View-->\r\n");
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