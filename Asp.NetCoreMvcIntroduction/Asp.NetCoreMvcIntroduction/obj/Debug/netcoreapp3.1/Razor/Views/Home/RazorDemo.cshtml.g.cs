#pragma checksum "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477376fa5055c21a5aa85762475ba652ce4bda05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RazorDemo), @"mvc.1.0.view", @"/Views/Home/RazorDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"477376fa5055c21a5aa85762475ba652ce4bda05", @"/Views/Home/RazorDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9322d73799f0fc6b352a79e93b68294e24463c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RazorDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asp.NetCoreMvcIntroduction.EmployeeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "477376fa5055c21a5aa85762475ba652ce4bda053670", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>RazorDemo</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "477376fa5055c21a5aa85762475ba652ce4bda054733", async() => {
                WriteLiteral("\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "477376fa5055c21a5aa85762475ba652ce4bda055010", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>City Id</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
             foreach (var item in Model.Employees)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                   Write(item.CityId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    Mail me : emre@gmail.com\r\n    I am ");
                WriteLiteral("@home\r\n\r\n    <p>");
#nullable restore
#line 42 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>3 days ago was ");
#nullable restore
#line 43 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                  Write(DateTime.Now - TimeSpan.FromDays(3));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> ");
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
      
        var number = 10;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    If\r\n");
#nullable restore
#line 49 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     if (number < 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Your number is less than 10</p>\r\n");
#nullable restore
#line 52 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }
    else if (number == 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>your number is 10</p>\r\n");
#nullable restore
#line 56 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>your number is greater than 10</p>\r\n");
#nullable restore
#line 60 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    Switch\r\n");
#nullable restore
#line 63 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     switch (number)
    {
        case 10:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>your number is 10</p>\r\n");
#nullable restore
#line 67 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;
        case 11:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>your number is 11</p>\r\n");
#nullable restore
#line 70 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;
        default:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>I have no idea about the number</p>\r\n");
#nullable restore
#line 73 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
            break;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    For\r\n");
#nullable restore
#line 77 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     for (int i = 0; i < Model.Employees.Count; i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /> <b>");
#nullable restore
#line 79 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
             Write(Model.Employees[i].FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n");
#nullable restore
#line 80 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 83 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     try
    {

    }
    catch (ArgumentNullException argument)
    {

        throw;
    }
    catch (Exception ex)
    {

        throw;
    }

    finally
    {

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 104 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
     using (Html.BeginForm())

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
                                                                                                                         
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"text\"");
                BeginWriteAttribute("id", " id=\"", 2095, "\"", 2100, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2101, "\"", 2108, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button type=\"submit\"></button>\r\n");
#nullable restore
#line 108 "C:\Users\EMRE-KESKINBICKI\source\repos\Asp.NetCoreMvcIntroduction\Asp.NetCoreMvcIntroduction\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.NetCoreMvcIntroduction.EmployeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591