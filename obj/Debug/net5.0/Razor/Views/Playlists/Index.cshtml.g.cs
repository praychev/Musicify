#pragma checksum "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd0bc65441363ee80afdb9f1922136e43e0f288d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Playlists_Index), @"mvc.1.0.view", @"/Views/Playlists/Index.cshtml")]
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
#line 3 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
using izpit.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0bc65441363ee80afdb9f1922136e43e0f288d", @"/Views/Playlists/Index.cshtml")]
    public class Views_Playlists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<izpit.ViewModels.Playlists.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
  
    this.Layout = "/Views/Shared/_Site.cshtml";
    ViewData["title"] = "PLAYLISTS";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Playlists/CreatePlayName\">NEW</a>\r\n\r\n<div class=\"grid\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
         if (Model.Items.Count()>0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3\">Title</div>\r\n");
#nullable restore
#line 16 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
        }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>You still don\'t have any playlists</p>\r\n");
#nullable restore
#line 20 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
     foreach (Playlist item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-1\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 649, "\"", 693, 2);
            WriteAttributeValue("", 656, "/Playlists/CreateFullPlay?id=", 656, 29, true);
#nullable restore
#line 29 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
WriteAttributeValue("", 685, item.Id, 685, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 30 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <hr>\r\n        </div>\r\n");
#nullable restore
#line 35 "D:\UNI\2курс\sem2\web dev\proektIzpit\izpit\Views\Playlists\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<izpit.ViewModels.Playlists.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
