#pragma checksum "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15754280dac553645af8d551ae791a383534ad84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Details.cshtml", typeof(AspNetCore.Views_Employees_Details))]
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
#line 1 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#line 2 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\_ViewImports.cshtml"
using WebApp1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15754280dac553645af8d551ae791a383534ad84", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6545200b2b1f984d3aecce45fd26db78e2f32d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UWofS.CS7.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 195, true);
            WriteLiteral("\r\n<!--Displays a view with all fields from the employees database.  -->\r\n\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(268, 38, false);
#line 16 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(306, 127, true);
            WriteLiteral("<!--Renders the display label that matches the specified expression ie EmployeeID-->\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(434, 40, false);
#line 19 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 130, true);
            WriteLiteral("<!--Renders the display property that matches the specified expression ie EmployeeID-->\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(605, 39, false);
#line 22 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(688, 41, false);
#line 25 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(729, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(773, 35, false);
#line 28 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(852, 37, false);
#line 31 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 45, false);
#line 34 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1022, 47, false);
#line 37 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1113, 39, false);
#line 40 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1196, 41, false);
#line 43 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1281, 38, false);
#line 46 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1363, 40, false);
#line 49 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1447, 37, false);
#line 52 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1528, 39, false);
#line 55 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1611, 34, false);
#line 58 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1689, 36, false);
#line 61 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1769, 36, false);
#line 64 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1849, 38, false);
#line 67 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1931, 40, false);
#line 70 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2015, 42, false);
#line 73 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2101, 37, false);
#line 76 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2182, 39, false);
#line 79 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2265, 39, false);
#line 82 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2348, 41, false);
#line 85 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2433, 39, false);
#line 88 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2516, 41, false);
#line 91 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2601, 35, false);
#line 94 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2680, 82, false);
#line 97 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.TextAreaFor(model => model.Notes, new { @class = "form-control", @rows = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2806, 39, false);
#line 100 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.LabelFor(model => model.ReportsTo));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2889, 41, false);
#line 103 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReportsTo));

#line default
#line hidden
            EndContext();
            BeginContext(2930, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2977, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43c3f2378fe499dba8a479cde9b892c", async() => {
                BeginContext(3031, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "D:\Research Methods\InternetScripting\B00368581V2017\WebApp1\Views\Employees\Details.cshtml"
                           WriteLiteral(Model.EmployeeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3039, 83, true);
            WriteLiteral(" |  <!--Add a link to the Edit view based on the current record employeeID-->\r\n    ");
            EndContext();
            BeginContext(3122, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da44fd7f0aad4048859515d0388095a8", async() => {
                BeginContext(3144, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3160, 48, true);
            WriteLiteral(" <!--Add a link to the Details view-->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UWofS.CS7.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591