#pragma checksum "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda28c0eadc002e2af899f309d2b997110d7379b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda28c0eadc002e2af899f309d2b997110d7379b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Employer</h2>\r\n\r\n<ul>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
     foreach (var employer in Model.employers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n           ");
#nullable restore
#line 18 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
      Write(employer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(employer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                  Write(employer.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                    Write(employer.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </li>\r\n");
#nullable restore
#line 20 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ul>\r\n    <li>\r\n");
#nullable restore
#line 25 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
         foreach (var cities in Model.Cities)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n           ");
#nullable restore
#line 28 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
      Write(cities);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 30 "C:\Users\NOT-004\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
