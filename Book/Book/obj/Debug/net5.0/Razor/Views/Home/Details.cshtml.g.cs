#pragma checksum "C:\Users\qubad\Desktop\Book\Book\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d8584187542f840bbed0394ff3067ed936e5500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\qubad\Desktop\Book\Book\Views\_ViewImports.cshtml"
using Book.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8584187542f840bbed0394ff3067ed936e5500", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6351d492185bbfc69807098ef742cc89168ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookk>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-8 offset-2"">
            <div class=""list-group"">
                <a href=""/home/index"" class=""list-group-item list-group-item-action active"" aria-current=""true"">
                    Geri qayit
                </a>
                <a href=""#"" class=""list-group-item list-group-item-action"">");
#nullable restore
#line 10 "C:\Users\qubad\Desktop\Book\Book\Views\Home\Details.cshtml"
                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 11 "C:\Users\qubad\Desktop\Book\Book\Views\Home\Details.cshtml"
                                                                      Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 12 "C:\Users\qubad\Desktop\Book\Book\Views\Home\Details.cshtml"
                                                                      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookk> Html { get; private set; }
    }
}
#pragma warning restore 1591