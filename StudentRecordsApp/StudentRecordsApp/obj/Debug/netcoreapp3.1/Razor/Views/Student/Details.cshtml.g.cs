#pragma checksum "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002f9470b63ef27aec7c5817abd4864d25c9c571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#line 1 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using StudentRecordsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using StudentRecordsApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002f9470b63ef27aec7c5817abd4864d25c9c571", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af852e96bdcc0aefcdb8389cabbdf36487512e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentRecordsApp.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grades));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Prelim Grade</th>
                    <th>Midterm Grade</th>
                    <th>Prefinal Grade</th>
                    <th>Final Grade</th>
                    <th>Grade</th>
                </tr>
");
#nullable restore
#line 62 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                 foreach (var item in Model.Grades)
                {
                    double totalPrelimQuiz = item.Prelim_Quiz1 + item.Prelim_Quiz2 + item.Prelim_Quiz3;
                    double averagePrelimQuiz = totalPrelimQuiz / 3;
                    double totalPrelimAssign = item.Prelim_Assign1 + item.Prelim_Assign2 + item.Prelim_Assign3;
                    double averagePrelimAssign = totalPrelimAssign / 3;
                    double prelimTotal = averagePrelimQuiz + averagePrelimAssign;
                    double PrelimGradeAve = Math.Round((double)prelimTotal/2, 2);

                    double totalMidtermQuiz = item.Midterm_Quiz1 + item.Midterm_Quiz2 + item.Midterm_Quiz3;
                    double averageMidtermQuiz = totalMidtermQuiz / 3;
                    double totalMidtermAssign = item.Midterm_Assign1 + item.Midterm_Assign2 + item.Midterm_Assign3;
                    double averageMidtermAssign = totalMidtermAssign / 3;
                    double midtermTotal = averageMidtermQuiz + averageMidtermAssign;
                    double MidtermGradeAve = Math.Round((double)midtermTotal / 2, 2);

                    double totalPrefinalQuiz = item.Prefinal_Quiz1 + item.Prefinal_Quiz2 + item.Prefinal_Quiz3;
                    double averagePrefinalQuiz = totalPrefinalQuiz / 3;
                    double totalPrefinalAssign = item.Prefinal_Assign1 + item.Prefinal_Assign2 + item.Prefinal_Assign3;
                    double averagePrefinalAssign = totalPrefinalAssign / 3;
                    double prefinalTotal = averagePrefinalQuiz + averagePrefinalAssign;
                    double PrefinalGradeAve = Math.Round((double)prefinalTotal / 2, 2);

                    double totalFinalQuiz = item.Final_Quiz1 + item.Final_Quiz2 + item.Final_Quiz3;
                    double averageFinalQuiz = totalFinalQuiz / 3;
                    double totalFinalAssign = item.Final_Assign1 + item.Final_Assign2 + item.Final_Assign3;
                    double averageFinalAssign = totalFinalAssign / 3;
                    double finalTotal = averageFinalQuiz + averageFinalAssign;
                    double FinalGradeAve = Math.Round((double)finalTotal / 2, 2);

                    double Grade = PrelimGradeAve + MidtermGradeAve + PrefinalGradeAve + FinalGradeAve;
                    double AveGrade = Math.Round((double)Grade / 4, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
               Write(Html.DisplayFor(modelItem => PrelimGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
               Write(Html.DisplayFor(modelItem => MidtermGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
               Write(Html.DisplayFor(modelItem => PrefinalGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
               Write(Html.DisplayFor(modelItem => FinalGradeAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
               Write(Html.DisplayFor(modelItem => AveGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </dd>
        <dt class=""col-sm-2"">
            Prelim Grades
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Quiz 1</th>
                    <th>Quiz 2</th>
                    <th>Quiz 3</th>
                    <th>Average</th>
                </tr>
");
#nullable restore
#line 125 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                 foreach (var item in Model.Grades)
                {
                    double totalPrelimQuiz = item.Prelim_Quiz1 + item.Prelim_Quiz2 + item.Prelim_Quiz3;
                    double averagePrelimQuiz = totalPrelimQuiz / 3;
                    double roundedAveQuiz = Math.Round((double)averagePrelimQuiz, 2);

                    double totalPrelimAssign = item.Prelim_Assign1 + item.Prelim_Assign2 + item.Prelim_Assign3;
                    double averagePrelimAssign = totalPrelimAssign / 3;
                    double roundedAveAssign = Math.Round((double)averagePrelimAssign, 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 137 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 140 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 143 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 146 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>

                    </tr>
                    <tr>
                        <th>Assignment 1</th>
                        <th>Assignment 2</th>
                        <th>Assignment 3</th>
                        <th>Average</th>
                    </tr>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 158 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 161 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 164 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prelim_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 167 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 170 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </dd>


        <dt class=""col-sm-2"">
            Midterm Grades
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Quiz 1</th>
                    <th>Quiz 2</th>
                    <th>Quiz 3</th>
                    <th>Average</th>
                </tr>
");
#nullable restore
#line 186 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                 foreach (var item in Model.Grades)
                {
                    double totalMidtermQuiz = item.Midterm_Quiz1 + item.Midterm_Quiz2 + item.Midterm_Quiz3;
                    double averageMidtermQuiz = totalMidtermQuiz / 3;
                    double roundedAveQuiz = Math.Round((double)averageMidtermQuiz, 2);

                    double totalMidtermAssign = item.Midterm_Assign1 + item.Midterm_Assign2 + item.Midterm_Assign3;
                    double averageMidtermAssign = totalMidtermAssign / 3;
                    double roundedAveAssign = Math.Round((double)averageMidtermAssign, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 197 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 200 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 203 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 206 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>

                    </tr>
                    <tr>
                        <th>Assignment 1</th>
                        <th>Assignment 2</th>
                        <th>Assignment 3</th>
                        <th>Average</th>
                    </tr>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 218 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 221 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 224 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Midterm_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 227 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 230 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </dd>

        <dt class=""col-sm-2"">
            Prefinal Grades
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Quiz 1</th>
                    <th>Quiz 2</th>
                    <th>Quiz 3</th>
                    <th>Average</th>
                </tr>
");
#nullable restore
#line 245 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                 foreach (var item in Model.Grades)
                {
                    double totalPrefinalQuiz = item.Prefinal_Quiz1 + item.Prefinal_Quiz2 + item.Prefinal_Quiz3;
                    double averagePrefinalQuiz = totalPrefinalQuiz / 3;
                    double roundedAveQuiz = Math.Round((double)averagePrefinalQuiz, 2);

                    double totalPrefinalAssign = item.Prefinal_Assign1 + item.Prefinal_Assign2 + item.Prefinal_Assign3;
                    double averagePrefinalAssign = totalPrefinalAssign / 3;
                    double roundedAveAssign = Math.Round((double)averagePrefinalAssign, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 256 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 259 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 262 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 265 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>

                    </tr>
                    <tr>
                        <th>Assignment 1</th>
                        <th>Assignment 2</th>
                        <th>Assignment 3</th>
                        <th>Average</th>
                    </tr>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 277 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 280 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 283 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Prefinal_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 286 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 289 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </dd>


        <dt class=""col-sm-2"">
            Final Grades
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Quiz 1</th>
                    <th>Quiz 2</th>
                    <th>Quiz 3</th>
                    <th>Average</th>
                </tr>
");
#nullable restore
#line 305 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                 foreach (var item in Model.Grades)
                {
                    double totalFinalQuiz = item.Final_Quiz1 + item.Final_Quiz2 + item.Final_Quiz3;
                    double averageFinalQuiz = totalFinalQuiz / 3;
                    double roundedAveQuiz = Math.Round((double)averageFinalQuiz, 2);

                    double totalFinalAssign = item.Final_Assign1 + item.Final_Assign2 + item.Final_Assign3;
                    double averageFinalAssign = totalFinalAssign / 3;
                    double roundedAveAssign = Math.Round((double)averageFinalAssign, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 316 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 319 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 322 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 325 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveQuiz));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>

                    </tr>
                    <tr>
                        <th>Assignment 1</th>
                        <th>Assignment 2</th>
                        <th>Assignment 3</th>
                        <th>Average</th>
                    </tr>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 337 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 340 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 343 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Final_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 346 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => roundedAveAssign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 349 "C:\Users\My Computer\source\repos\StudentRecordsApp\StudentRecordsApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentRecordsApp.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591