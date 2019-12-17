#pragma checksum "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a64679c4f09c2add78b4bc547d0f7ed58e313f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentDetails), @"mvc.1.0.view", @"/Views/Shared/_CommentDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentDetails.cshtml", typeof(AspNetCore.Views_Shared__CommentDetails))]
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
#line 1 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
using Services.DTOs;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
using Web.Utils;

#line default
#line hidden
#line 3 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
using Web.Views.Shared;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a64679c4f09c2add78b4bc547d0f7ed58e313f", @"/Views/Shared/_CommentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
  
    CommentDto comment = Model.CommentDto;

    string thumbUpClass = "noReaction";
    string thumbDownClass = "noReaction";

    if (User.Identity.IsAuthenticated)
    {
        string userId = Helper.GetUserId(User);

        if (Model.CommentDto.WhoLiked.Contains(userId))
        {
            thumbUpClass = "liked";
        }
        else if (Model.CommentDto.WhoDisliked.Contains(userId))
        {
            thumbDownClass = "disliked";
        }
    }

#line default
#line hidden
            BeginContext(564, 3, true);
            WriteLiteral("\n<a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 567, "\"", 583, 1);
#line 27 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 572, comment.Id, 572, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(584, 73, true);
            WriteLiteral("></a>\n<div class=\"single-comment-wrapper\">\n    <div class=\"user-ava\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 657, "\"", 681, 1);
#line 29 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 663, comment.UserPhoto, 663, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 682, "\"", 705, 1);
#line 29 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 688, comment.UserName, 688, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(706, 63, true);
            WriteLiteral(" /></div>\n    <div>\n        <div class=\"username\">\n            ");
            EndContext();
            BeginContext(770, 16, false);
#line 32 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
       Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(786, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 33 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
             if (!comment.IsDeleted)
            {

#line default
#line hidden
            BeginContext(838, 46, true);
            WriteLiteral("                <span class=\"comment-created\">");
            EndContext();
            BeginContext(885, 39, false);
#line 35 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                         Write(Helper.GetRelativeTime(comment.Created));

#line default
#line hidden
            EndContext();
            BeginContext(924, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 36 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(946, 15, true);
            WriteLiteral("        </div>\n");
            EndContext();
#line 38 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
         if (comment.IsDeleted)
        {

#line default
#line hidden
            BeginContext(1003, 75, true);
            WriteLiteral("            <div class=\"deleted-comment-text\">Комментарий был удален</div>\n");
            EndContext();
#line 41 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1111, 38, true);
            WriteLiteral("            <div class=\"comment-text\">");
            EndContext();
            BeginContext(1150, 12, false);
#line 44 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                 Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1162, 89, true);
            WriteLiteral("</div>\n            <span style=\"font-size:11px; font-weight:bold;\">\n                <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1251, "\"", 1273, 2);
#line 46 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 1256, comment.Id, 1256, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1267, "-likes", 1267, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1274, "\"", 1295, 1);
#line 46 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 1282, thumbUpClass, 1282, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1296, 72, true);
            WriteLiteral(">\n                    <span data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(1369, 10, false);
#line 47 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                 Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(1384, 23, false);
#line 47 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                                Write(comment.ParentCommentId);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 65, true);
            WriteLiteral("\', true) }\">\n                        <span class=\"comment-likes\">");
            EndContext();
            BeginContext(1473, 13, false);
#line 48 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                               Write(comment.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 161, true);
            WriteLiteral("</span>\n                        <i class=\"far fa-thumbs-up\"></i>\n                    </span>\n                </span>\n                &nbsp;\n                <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1647, "\"", 1672, 2);
#line 53 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 1652, comment.Id, 1652, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1663, "-dislikes", 1663, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1673, "\"", 1696, 1);
#line 53 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
WriteAttributeValue("", 1681, thumbDownClass, 1681, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1697, 72, true);
            WriteLiteral(">\n                    <span data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(1770, 10, false);
#line 54 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                 Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(1785, 23, false);
#line 54 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                                Write(comment.ParentCommentId);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 69, true);
            WriteLiteral("\', false) }\">\n                        <span class=\"comment-dislikes\">");
            EndContext();
            BeginContext(1878, 16, false);
#line 55 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                  Write(comment.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 120, true);
            WriteLiteral("</span>\n                        <i class=\"far fa-thumbs-down\"></i>\n                    </span>\n                </span>\n\n");
            EndContext();
#line 60 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

                    string userName = Model.DisplayUserName ? comment.UserName : "";

#line default
#line hidden
            BeginContext(2170, 82, true);
            WriteLiteral("                    <span data-bind=\"click: function() { displayAnswerCommentBox(\'");
            EndContext();
            BeginContext(2253, 10, false);
#line 64 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                             Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(2268, 8, false);
#line 64 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                                                                                            Write(userName);

#line default
#line hidden
            EndContext();
            BeginContext(2276, 98, true);
            WriteLiteral("\') }\" class=\"answer-comment-action\">\n                        Ответить\n                    </span>\n");
            EndContext();
#line 67 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
                }

#line default
#line hidden
            BeginContext(2392, 20, true);
            WriteLiteral("            </span>\n");
            EndContext();
#line 69 "C:\Users\omarf\Desktop\youit-master\youit-master\Web\Views\Shared\_CommentDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(2422, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
