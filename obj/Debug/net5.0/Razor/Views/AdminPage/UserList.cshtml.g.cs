#pragma checksum "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d95bb3eed32bd8a4b8435effbce2fc9fba9cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPage_UserList), @"mvc.1.0.view", @"/Views/AdminPage/UserList.cshtml")]
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
#line 1 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\_ViewImports.cshtml"
using ASPNETAOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\_ViewImports.cshtml"
using ASPNETAOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d95bb3eed32bd8a4b8435effbce2fc9fba9cf7", @"/Views/AdminPage/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9795f2e547f07358bc97161cb383735641ff9df", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPage_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPNETAOP.Models.AdminPage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
  
    ViewData["Title"] = "UserList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Users</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>User Name</th>\r\n        <th>Mail</th>\r\n        <th>Role</th>\r\n        <th>Login Date</th>\r\n        <th>IsLoggedIn</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.Usermail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.Rolename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.LoginDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
           Write(user.IsLoggedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Cenk\source\repos\ASPNET-CORE-MVC-AOP-APP-main\Views\AdminPage\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPNETAOP.Models.AdminPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
