#pragma checksum "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7a889a4d1da8df2871bec360d5aadc5c67bb82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 2 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
using Web.Utils;

#line default
#line hidden
#line 3 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7a889a4d1da8df2871bec360d5aadc5c67bb82", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.PostDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/full-post.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
  
    string thumbUpClass = "noReaction";
    string thumbDownClass = "noReaction";

    if (User.Identity.IsAuthenticated)
    {
        string userId = Helper.GetUserId(User);
        if (Model.WhoLiked.Contains(userId))
        {
            thumbUpClass = "liked";
        }
        else if (Model.WhoDisliked.Contains(userId))
        {
            thumbDownClass = "disliked";
        }
    }

#line default
#line hidden
            BeginContext(487, 38, true);
            WriteLiteral("\n<div class=\"box full-post\">\n\n    <h1>");
            EndContext();
            BeginContext(526, 11, false);
#line 25 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(537, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 27 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
      
        string postUrl = "http://youit.pro/post/" + Model.Url;

        string shareVK = "https://vk.com/share.php?url=" + postUrl;
        string shareFB = "https://www.facebook.com/sharer/sharer.php?u=" + postUrl;
        string shareLI = "https://www.linkedin.com/sharing/share-offsite/?url=" + postUrl;
    

#line default
#line hidden
            BeginContext(864, 85, true);
            WriteLiteral("\n    <div id=\"post-statistic\">\n        <div>\n\n            <i class=\"far fa-eye\"></i> ");
            EndContext();
            BeginContext(950, 20, false);
#line 38 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                  Write(Model.ViewsFormatted);

#line default
#line hidden
            EndContext();
            BeginContext(970, 100, true);
            WriteLiteral(" &nbsp;\n            <a href=\"#begin-comments\" style=\"color:#9b9b9b;\"><i class=\"far fa-comment\"></i> ");
            EndContext();
            BeginContext(1071, 19, false);
#line 39 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                                                                       Write(Model.CommentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 46, true);
            WriteLiteral("</a> &nbsp;\n\n            <span id=\"post-likes\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1136, "\"", 1157, 1);
#line 41 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1144, thumbUpClass, 1144, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1158, 41, true);
            WriteLiteral(" data-bind=\"click: function() { setLike(\'");
            EndContext();
            BeginContext(1200, 8, false);
#line 41 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                                                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 86, true);
            WriteLiteral("\') }\" style=\"cursor:pointer;\">\n                <i class=\"far fa-thumbs-up\"></i> <span>");
            EndContext();
            BeginContext(1295, 11, false);
#line 42 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                                  Write(Model.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 71, true);
            WriteLiteral("</span>\n            </span> &nbsp;\n            <span id=\"post-dislikes\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1377, "\"", 1400, 1);
#line 44 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1385, thumbDownClass, 1385, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1401, 44, true);
            WriteLiteral(" data-bind=\"click: function() { setDislike(\'");
            EndContext();
            BeginContext(1446, 8, false);
#line 44 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                                                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1454, 88, true);
            WriteLiteral("\') }\" style=\"cursor:pointer;\">\n                <i class=\"far fa-thumbs-down\"></i> <span>");
            EndContext();
            BeginContext(1543, 14, false);
#line 45 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                                                    Write(Model.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 59, true);
            WriteLiteral("</span>\n            </span>\n\n            | <span>Добавлено ");
            EndContext();
            BeginContext(1617, 37, false);
#line 48 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
                         Write(Helper.GetRelativeTime(Model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 91, true);
            WriteLiteral("</span> &nbsp;\n        </div>\n       \n        <div style=\"margin-top:10px;\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1745, "\"", 1760, 1);
#line 52 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1752, shareVK, 1752, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1761, 182, true);
            WriteLiteral(" class=\"pure-button pure-button-primary social-share-button\" style=\"background-color:#45668e;\">\n                ВК <i class=\"far fa-share-square\"></i>\n            </a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1943, "\"", 1958, 1);
#line 55 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 1950, shareFB, 1950, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1959, 182, true);
            WriteLiteral(" class=\"pure-button pure-button-primary social-share-button\" style=\"background-color:#3b5998;\">\n                FB <i class=\"far fa-share-square\"></i>\n            </a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2141, "\"", 2156, 1);
#line 58 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
WriteAttributeValue("", 2148, shareLI, 2148, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2157, 231, true);
            WriteLiteral(" class=\"pure-button pure-button-primary social-share-button\" style=\"background-color:#0e76a8;\">\n                LI <i class=\"far fa-share-square\"></i>\n            </a>\n        </div>\n    </div>\n\n    <div class=\"post-text\">\n        ");
            EndContext();
            BeginContext(2389, 20, false);
#line 65 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 18, true);
            WriteLiteral("\n    </div>\n\n\n    ");
            EndContext();
            BeginContext(2428, 47, false);
#line 69 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Home\Post.cshtml"
Write(await Html.PartialAsync("_PostComments", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 502, true);
            WriteLiteral(@"

    <p></p>
    <p><b>Вас также может заинтересовать</b></p>
    <div id=""more-posts"" class=""more-posts-section"">
        <!-- ko foreach: morePosts -->
        <div style=""margin-bottom:30px;"">
            <a data-bind=""attr: { href: url }"">
                <img style=""max-width:100%; border-radius:3px;"" data-bind=""attr: { src: image, alt: title }"" />
                <h3 data-bind=""text: title"" style=""margin-top:0px;""></h3>
            </a>
        </div>
        <!-- /ko -->
    </div>
</div>
");
            EndContext();
            BeginContext(2977, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4194e16f50564d94bf32b3a3e2b1c9ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("async", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3024, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.PostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
