#pragma checksum "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19272b22433d851b62dae80732cc373a13dda85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllItems), @"mvc.1.0.view", @"/Views/Home/AllItems.cshtml")]
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
#line 4 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
using TestEFC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
using TestEFC.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19272b22433d851b62dae80732cc373a13dda85b", @"/Views/Home/AllItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abc981167768e32967733ebdd48c47f370c1485", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Item, FileStreamResult>>
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
#nullable restore
#line 7 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
  
    string str="/uploads/";
    string url = string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19272b22433d851b62dae80732cc373a13dda85b3663", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
     if( TempData["Name"]!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <p>");
#nullable restore
#line 23 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
       Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
     if(User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a href=\"/Logout\"> Log out</a>\r\n");
#nullable restore
#line 29 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n</div>\r\n\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 36 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
     if(Model!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         <table class=""table table-striped"">
              <thead>
    <tr>
    
      <th scope=""col"">Id</th>
      <th scope=""col"">Name</th>
       <th scope=""col"">Price</th>
        <th scope=""col"">Count</th>
        <th scope=""col"">Image</th>
  
    </tr>
  </thead>
        
");
#nullable restore
#line 51 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
         foreach(var i in Model)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 56 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                   Write(i.Key.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 57 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                  Write(i.Key.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                 \r\n");
#nullable restore
#line 59 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                       if(@i.Key.Count==0)
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <td>\r\n                         Not available\r\n                          \r\n                       </td>   \r\n");
#nullable restore
#line 65 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                      }
                      else
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <td>\r\n                           ");
#nullable restore
#line 69 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                      Write(i.Key.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                       </td>\r\n");
#nullable restore
#line 71 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <td>\r\n");
                WriteLiteral("                    <img class=\"img\"");
                BeginWriteAttribute("src", " src=\"", 1899, "\"", 1939, 2);
                WriteAttributeValue("", 1905, "/uploads/", 1905, 9, true);
#nullable restore
#line 75 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
WriteAttributeValue("", 1914, Url.Content(i.Key.Image), 1914, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                      </td>\r\n\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 80 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </table>\r\n");
#nullable restore
#line 85 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
                WriteLiteral("       \r\n</div>\r\n <img");
                BeginWriteAttribute("src", " src=\"", 2306, "\"", 2342, 2);
                WriteAttributeValue("", 2312, "upload/", 2312, 7, true);
#nullable restore
#line 92 "C:\Users\user\source\repos\TestEFC\TestEFC\Views\Home\AllItems.cshtml"
WriteAttributeValue("", 2319, Model.Last().Key.Image, 2319, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("height=\"250px\" width=\"500px\" />\r\n");
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
            WriteLiteral(" \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<Item, FileStreamResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
