#pragma checksum "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744e0070f6c2df67c84f8796138cb7f5e4cbd4fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Map), @"mvc.1.0.view", @"/Views/Home/Map.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Map.cshtml", typeof(AspNetCore.Views_Home_Map))]
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
#line 1 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744e0070f6c2df67c84f8796138cb7f5e4cbd4fa", @"/Views/Home/Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.PostMapViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 145, true);
            WriteLiteral("\r\n    <div class=\"box full-post\">\r\n        <h1>Все статьи сайта</h1>\r\n        <h3>\r\n            Программирование\r\n        </h3>\r\n\r\n        <ul>\r\n");
            EndContext();
#line 10 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
             foreach (var post in Model.Programming)
            {

#line default
#line hidden
            BeginContext(250, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 272, "\"", 294, 2);
            WriteAttributeValue("", 279, "/post/", 279, 6, true);
#line 12 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
WriteAttributeValue("", 285, post.Url, 285, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(295, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(297, 10, false);
#line 12 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
                                         Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(307, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 13 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
            }

#line default
#line hidden
            BeginContext(333, 88, true);
            WriteLiteral("        </ul>\r\n\r\n        <h3>\r\n            Карьера в IT\r\n        </h3>\r\n\r\n        <ul>\r\n");
            EndContext();
#line 21 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
             foreach (var post in Model.Career)
            {

#line default
#line hidden
            BeginContext(485, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 507, "\"", 529, 2);
            WriteAttributeValue("", 514, "/post/", 514, 6, true);
#line 23 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
WriteAttributeValue("", 520, post.Url, 520, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(530, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(532, 10, false);
#line 23 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
                                         Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(542, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 24 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Map.cshtml"
            }

#line default
#line hidden
            BeginContext(568, 29, true);
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.PostMapViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
