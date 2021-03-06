#pragma checksum "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66513884a2388f655414eb50c579038648e5ecb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firebase_User), @"mvc.1.0.view", @"/Views/Firebase/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66513884a2388f655414eb50c579038648e5ecb4", @"/Views/Firebase/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3418e291afa96ca0b3dfec0b2869863b5c282567", @"/Views/_ViewImports.cshtml")]
    public class Views_Firebase_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Firebase_a.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
  
    ViewData["Title"] = "Firebase Users Record Management";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h5 class=\"display-5\">Let\'s manage users records</h5>\n\n  <div class=\"row\">\n        <div class=\"col-md-12\">\n            <h3>Add User</h3>\n");
#nullable restore
#line 12 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
             using (Html.BeginForm("User","Firebase",FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"form-group\">\n                    <label for=\"firstName\">First Name</label>                                         \n                    ");
#nullable restore
#line 16 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
               Write(Html.TextBoxFor(a=>a.firstName,new{@class="form-control",@id="firstName", aria_describedby="firstNameHelp", @placeholder="First Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <small id=\"firstNameHelp\" class=\"form-text text-muted\">Write your first name.</small>\n                </div>\n               <div class=\"form-group\">\n                    <label for=\"lastName\">Last Name</label>\n                    ");
#nullable restore
#line 21 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
               Write(Html.TextBoxFor(a=>a.lastName,new{@class="form-control",@id="lastName", aria_describedby="lastNameHelp", @placeholder="Last Name"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <small id=\"lastNameHelp\" class=\"form-text text-muted\">Write your last name.</small>\n                </div>\n                <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n");
#nullable restore
#line 25 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
             using (Html.BeginForm("UserDelete","Firebase",new{@id=ViewBag.ItemID}))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-danger\">Delete</button> \n");
#nullable restore
#line 29 "/Users/aykut/Desktop/Firebase-a/Views/Firebase/User.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Firebase_a.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
