#pragma checksum "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0610914f201a5b242ce4d90581c96a7915e0c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\_ViewImports.cshtml"
using Restaurant_DotnetCoreMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\_ViewImports.cshtml"
using Restaurant_DotnetCoreMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0610914f201a5b242ce4d90581c96a7915e0c2", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa1eb950c84d542d0303f5302be0c69c267a5c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopingCards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
  <div class=""carousel-inner"">
    <div class=""carousel-item active"">
      <img class=""d-block w-100 img-fluid"" src=""https://media.istockphoto.com/photos/empty-restaurant-interior-picture-id1288064106?b=1&k=20&m=1288064106&s=170667a&w=0&h=hLfSBeMPduZyld4su0c3ju-yMPGOouuk_3Gzv7S4Jwo="" alt=""First slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100 img-fluid"" src=""https://media.istockphoto.com/photos/empty-restaurant-interior-picture-id1290237592?b=1&k=20&m=1290237592&s=170667a&w=0&h=fgXWrrQ7qWpbiO8O_dpEVlS4JsTZYH8e3FoZ4UeoQH8="" alt=""Second slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100 img-fluid"" src=""https://media.istockphoto.com/photos/sacrificed-a-lot-for-this-startup-to-come-true-picture-id1303648971?b=1&k=20&m=1303648971&s=170667a&w=0&h=75SWYZMDFAzCZ7PvVjKJJW6ABvR7U2MJupml1yRtJMo="" alt=""Third slide"">
    </div>
  </div>
  <a class=""carousel-co");
            WriteLiteral(@"ntrol-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
</div>

<div class=""container"">
  <div class=""row"">
");
#nullable restore
#line 28 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"col-md-4 my-4\">\r\n               <div class=\"card\">\r\n                  <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1722, "\"", 1751, 1);
#nullable restore
#line 32 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
WriteAttributeValue("", 1728, item.ImageThumbnailUrl, 1728, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                  <div class=\"card-body\">\r\n                    <h3 class=\"card-text\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb0610914f201a5b242ce4d90581c96a7915e0c27133", async() => {
#nullable restore
#line 34 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 35 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb0610914f201a5b242ce4d90581c96a7915e0c210203", async() => {
                WriteLiteral("Add To shoping Cards");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                  </div>\r\n               </div>\r\n              </div>\r\n");
#nullable restore
#line 40 "C:\Users\MOHCINE\source\repos\Restaurant_DotnetCoreMvc\Restaurant_DotnetCoreMvc\Views\Pie\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pie>> Html { get; private set; }
    }
}
#pragma warning restore 1591