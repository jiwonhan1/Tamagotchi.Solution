#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf12b028d21072d34acd720859f1acb97b06942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamagotchis_Index), @"mvc.1.0.view", @"/Views/Tamagotchis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tamagotchis/Index.cshtml", typeof(AspNetCore.Views_Tamagotchis_Index))]
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
#line 4 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
using TamagotchiGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf12b028d21072d34acd720859f1acb97b06942", @"/Views/Tamagotchis/Index.cshtml")]
    public class Views_Tamagotchis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(56, 60, true);
            WriteLiteral("<div class=\"container\">\n  <h1>Your Tamagotchis!</h1>\n  <ul>\n");
            EndContext();
#line 8 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(149, 39, true);
            WriteLiteral("      <li>You have no Tamagotchis</li>\n");
            EndContext();
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(194, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if (tamagotchi.GetLife())
      {

#line default
#line hidden
            BeginContext(286, 27, true);
            WriteLiteral("        <li>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 313, "\"", 347, 2);
            WriteAttributeValue("", 320, "/tamagotchis/", 320, 13, true);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
WriteAttributeValue("", 333, tamagotchi.Id, 333, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(350, 15, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                             Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(365, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(368, 15, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                               Write(tamagotchi.Food);

#line default
#line hidden
            EndContext();
            BeginContext(383, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(386, 16, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                 Write(tamagotchi.Sleep);

#line default
#line hidden
            EndContext();
            BeginContext(402, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(405, 20, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
                                                                                                    Write(tamagotchi.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(425, 19, true);
            WriteLiteral("</a>\n        </li>\n");
            EndContext();
#line 19 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(458, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     foreach (Tamagotchi tamagotchi in Model)
    {
      if(@tamagotchi.GetLife() == false)
      {

#line default
#line hidden
            BeginContext(560, 23, true);
            WriteLiteral("        <li>\n          ");
            EndContext();
            BeginContext(584, 15, false);
#line 27 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
     Write(tamagotchi.Name);

#line default
#line hidden
            EndContext();
            BeginContext(599, 24, true);
            WriteLiteral(" is dead.\n        </li>\n");
            EndContext();
#line 29 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Tamagotchi.Solution/Tamagotchi/Views/Tamagotchis/Index.cshtml"
      }
    }

#line default
#line hidden
            BeginContext(637, 250, true);
            WriteLiteral("  </ul>\n\n  <form action=\"/tamagotchis/time\" method=\"post\">\n    <button type=\"submit\" name=\"button\">Pass Time</button>\n  </form>\n\n  <a href=\"/tamagotchis/new\">Add A Tamagotchi</a>\n  <a href=\"/tamagotchis/deleteAll\">Delete All Tamagotchis</a>\n</div>\n\n\n");
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
