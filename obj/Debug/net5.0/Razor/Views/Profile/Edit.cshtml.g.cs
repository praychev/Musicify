#pragma checksum "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dddcfc9a9ea544409b4d7d801ce2d55eeced00cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Edit), @"mvc.1.0.view", @"/Views/Profile/Edit.cshtml")]
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
#line 2 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
using izpit.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
using izpit.ExtentionMethods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dddcfc9a9ea544409b4d7d801ce2d55eeced00cf", @"/Views/Profile/Edit.cshtml")]
    public class Views_Profile_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<izpit.ViewModels.Profile.EditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
  
    this.Layout = "/Views/Shared/_Site.cshtml";
    ViewData["title"] = "EDIT USER";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
  
    User loggedUser = this.ViewContext.HttpContext.Session.GetObject<User>("loggedUser");

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n    <legend>EDIT PROFILE</legend>\r\n    <form action=\"/Profile/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 17 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 22 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 25 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 29 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 35 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 38 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 41 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 48 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 51 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 54 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 61 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 64 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 67 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Profile\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>

            </div>

            <div class=""row"">

                <div class=""col-3"">

                    <a class=""right"" href=""/Profile/Index"">BACK</a>
                    <input type=""submit"" class=""right"" value=""Save"" />
                </div>
            </div>
        </div>
    </form>
</fieldset>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<izpit.ViewModels.Profile.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591