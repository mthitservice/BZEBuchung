#pragma checksum "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc61d0017cf5a8b11c1de1df2d2363d273e49de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BZEBuchung.Pages.Pages_Buchungen), @"mvc.1.0.razor-page", @"/Pages/Buchungen.cshtml")]
namespace BZEBuchung.Pages
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
#line 1 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\_ViewImports.cshtml"
using BZEBuchung;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc61d0017cf5a8b11c1de1df2d2363d273e49de", @"/Pages/Buchungen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c588663dc845eaf56b85847052eaad78e9f769", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buchungen : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
  
    ViewData["Title"] = "Buchungen";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Buchungen</h1>
<div class=""text-center"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">von</th>
                <th scope=""col"">bis</th>
                <th scope=""col"">Teilnehmeranzahl</th>
                <th scope=""col"">Raum</th>
                <th scope=""col"">Etage</th>
                <th scope=""col"">Haus</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 22 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
             foreach (var item in Model.Buchungen)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 25 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                               Write(item.Buchung_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 26 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.von);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.bis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.Teilnehmeranzahl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.Raumbezeichnung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.Etagenbezeichnung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
                   Write(item.Hausbezeichnung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Projekt\BZEBuchung\BZEBuchung\Pages\Buchungen.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuchungenModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BuchungenModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BuchungenModel>)PageContext?.ViewData;
        public BuchungenModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
