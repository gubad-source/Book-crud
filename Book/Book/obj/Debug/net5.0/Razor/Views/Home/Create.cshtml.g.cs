#pragma checksum "C:\Users\qubad\Desktop\Book\Book\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9daeffc6db7ff1ea4832872eaa0788fd451f0b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daeffc6db7ff1ea4832872eaa0788fd451f0b6f", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6351d492185bbfc69807098ef742cc89168ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-8 offset-2"">
            <form method=""post"">
                <fieldset>
                    <legend>Yaratmaq</legend>
                    <div class=""mb-3"">
                        <label for=""authorId"" class=""form-label"">
                            Author
                        </label>
                        <input id=""authorId"" name=""Author"" class=""form-control"" />
                    </div>
                    <div class=""mb-3"">
                        <label for=""genreId"" class=""form-label"">
                            Genre
                        </label>
                        <input id=""genreId"" name=""Genre"" class=""form-control"" />
                    </div>
                    <div class=""mb-3"">
                        <label for=""priceId"" class=""form-label"">
                            Price
                        </label>
                        <input id=""priceId"" name=""Price"" class=""form-control"" ");
            WriteLiteral("/>\r\n                    </div>\r\n                    ");
#nullable restore
#line 26 "C:\Users\qubad\Desktop\Book\Book\Views\Home\Create.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\">\r\n                        Gonder\r\n                    </button>\r\n                </fieldset>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
