#pragma checksum "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4afbc2f4359719b904ba175ba23e5f2e4300ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firebase_Brand), @"mvc.1.0.view", @"/Views/Firebase/Brand.cshtml")]
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
#line 1 "/Users/aykut/Desktop/Firebase-a/Views/_ViewImports.cshtml"
using Firebase_a;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aykut/Desktop/Firebase-a/Views/_ViewImports.cshtml"
using Firebase_a.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4afbc2f4359719b904ba175ba23e5f2e4300ac", @"/Views/Firebase/Brand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3418e291afa96ca0b3dfec0b2869863b5c282567", @"/Views/_ViewImports.cshtml")]
    public class Views_Firebase_Brand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Firebase_a.Models.Brand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
  
    ViewData["Title"] = "Firebase Brands Record Management";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h5 class=\"display-5\">Let\'s manage brands records</h5>\n\n  <div class=\"row\">\n        <div class=\"col-md-12\">\n            <h3>Add Brand</h3>\n");
#nullable restore
#line 12 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
              using (Html.BeginForm("Brand","Firebase",FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\n                    <label for=\"brandName\">Brand Name</label>\n                    ");
#nullable restore
#line 16 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
               Write(Html.TextBoxFor(a=>a.name,new{@class="form-control",@id="brandName", aria_describedby="brandNameHelp", @placeholder="Brand Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <small id=\"brandNameHelp\" class=\"form-text text-muted\">Write the brand name.</small>\n                </div>\n               <div class=\"form-group\">\n                    <label for=\"webSite\">Web Site</label>\n                    ");
#nullable restore
#line 21 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
               Write(Html.TextBoxFor(a=>a.website,new{@class="form-control",@id="webSite", aria_describedby="webSiteHelp", @placeholder="Web Site"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <small id=\"webSiteHelp\" class=\"form-text text-muted\">Write the web site.</small>\n                </div>\n                <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n");
#nullable restore
#line 25 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
              using (Html.BeginForm("BrandDelete","Firebase",new{@id=ViewBag.ItemID}))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-danger\">Delete</button> \n");
#nullable restore
#line 29 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/Brand.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Firebase_a.Models.Brand> Html { get; private set; }
    }
}
#pragma warning restore 1591