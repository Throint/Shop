#pragma checksum "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7119dc224bf00ad82aa4cc1aeb84afa12d4b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CurrentCart), @"mvc.1.0.view", @"/Views/Home/CurrentCart.cshtml")]
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
#line 1 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\_ViewImports.cshtml"
using TestEFC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
using TestEFC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7119dc224bf00ad82aa4cc1aeb84afa12d4b42", @"/Views/Home/CurrentCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abc981167768e32967733ebdd48c47f370c1485", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CurrentCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<(int, Item, decimal)>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
  
    decimal PriceValue = Model.LastOrDefault().Item3;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7119dc224bf00ad82aa4cc1aeb84afa12d4b423530", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
     if( TempData["Name"]!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <p>");
#nullable restore
#line 27 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
       Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
     if(User.Identity.IsAuthenticated)
    {
      
        //<a href="Home/Logout"> Log out</a>
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
   Write(Html.ActionLink("Log out", "Logout"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                                             ;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n</div>\r\n\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 41 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
     if(Model!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <table class=\"table table-striped\">\r\n              <thead>\r\n    <tr>\r\n    \r\n      <th scope=\"col\">Id</th>\r\n      <th scope=\"col\">Name</th>\r\n       <th scope=\"col\">Price</th>\r\n     \r\n  \r\n    </tr>\r\n  </thead>\r\n        \r\n");
#nullable restore
#line 55 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
         foreach(var i in Model)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 60 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                   Write(i.Item1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 61 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                  Write(i.Item2?.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                     <td>");
#nullable restore
#line 62 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                    Write(i.Item2.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                   Write(Html.ActionLink("Remove", "RemoveFromCart","Home", new {id=@i.Item1}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                  \r\n\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 68 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>Total price</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
           Write(PriceValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n\r\n           </table>\r\n");
#nullable restore
#line 79 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
     if(Model.Count>0)
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
Write(Html.ActionLink("Create order", "OrderCreate","Home"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\CurrentCart.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n    </div>\r\n");
                WriteLiteral("       \r\n</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<(int, Item, decimal)>> Html { get; private set; }
    }
}
#pragma warning restore 1591
