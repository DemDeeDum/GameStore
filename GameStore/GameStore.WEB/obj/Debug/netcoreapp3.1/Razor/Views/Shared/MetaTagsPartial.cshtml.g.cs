#pragma checksum "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83fe93be8869379175423e3658d0d73391c34ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetaTagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetaTagsPartial.cshtml")]
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
#line 2 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\_ViewImports.cshtml"
using GameStore.WEB.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fe93be8869379175423e3658d0d73391c34ab8", @"/Views/Shared/MetaTagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9877e130195d23d7125f11eb5c09d676fa0bdc27", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetaTagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"UTF-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
#nullable restore
#line 3 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
 if(ViewBag.Description is { })
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 160, "\"", 190, 1);
#nullable restore
#line 5 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 170, ViewBag.Description, 170, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 6 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
 if(ViewBag.Keywords is { })
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 257, "\"", 284, 1);
#nullable restore
#line 9 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 267, ViewBag.Keywords, 267, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 10 "C:\Users\Дима\Documents\GitHub\GameStore\GameStore\GameStore.WEB\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
