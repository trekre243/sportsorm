#pragma checksum "C:\Users\tkrec\Downloads\c#\SportsORM\Views\Home\Level2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2d3e89d89ca1fc7de6a8bd0deb2a7b6d0cde9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Level2), @"mvc.1.0.view", @"/Views/Home/Level2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Level2.cshtml", typeof(AspNetCore.Views_Home_Level2))]
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
#line 1 "C:\Users\tkrec\Downloads\c#\SportsORM\Views\_ViewImports.cshtml"
using SportsORM;

#line default
#line hidden
#line 2 "C:\Users\tkrec\Downloads\c#\SportsORM\Views\_ViewImports.cshtml"
using SportsORM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2d3e89d89ca1fc7de6a8bd0deb2a7b6d0cde9d", @"/Views/Home/Level2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a84e242283cdb641f30a7b0c0ba0e5ada8d6e8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Level2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\tkrec\Downloads\c#\SportsORM\Views\Home\Level2.cshtml"
  
    ViewData["Title"] = "Level 2";

#line default
#line hidden
            BeginContext(43, 1518, true);
            WriteLiteral(@"
<div class=""well"">
    <p>Using the SportsORM, complete all the following queries and show their results on Level2.cshtml.</p>
    <ol>
        <li>...all teams in the Atlantic Soccer Conference</li>
        <li>...all (current) players on the Boston Penguins</li>
        <li>...all (current) players in the International Collegiate Baseball Conference</li>
        <li>...all (current) players in the American Conference of Amateur Football with last name ""Lopez""</li>
        <li>...all football players</li>
        <li>...all teams with a (current) player named ""Sophia""</li>
        <li>...all leagues with a (current) player named ""Sophia""</li>
        <li>...everyone with the last name ""Flores"" who DOESN'T (currently) play for the Washington Roughriders</li>
        <li>...all teams, past and present, that Samuel Evans has played with</li>
        <li>...all players, past and present, with the Manitoba Tiger-Cats</li>
        <li>...all players who were formerly (but aren't currently) with the ");
            WriteLiteral(@"Wichita Vikings</li>
        <li>...every team that Jacob Gray played for before he joined the Oregon Colts</li>
        <li>...everyone named ""Joshua"" who has ever played in the Atlantic Federation of Amateur Baseball Players</li>
        <li>...all teams that have had 12 or more players, past and present. (HINT: Look up the Django annotate function.)</li>
        <li>...all players and count of teams played for, sorted by the number of teams they've played for</li>
    </ol>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591