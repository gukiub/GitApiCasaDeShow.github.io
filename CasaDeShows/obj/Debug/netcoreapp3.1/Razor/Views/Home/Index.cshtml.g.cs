#pragma checksum "C:\Users\GOLS\Desktop\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b8036decec6375e8f5b402d115fe2a3ef5ab63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\GOLS\Desktop\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GOLS\Desktop\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\GOLS\Desktop\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b8036decec6375e8f5b402d115fe2a3ef5ab63", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f030387913ed64a7e79ec103a2f6dadfadf4bad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1 rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\GOLS\Desktop\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""banner_part container-batata"" id=""home"">
            <div class=""container"">
                <div class=""row align-items-center justify-content-between"">
                    <div class=""col-lg-6 col-md-8"">
                        <div class=""banner_text"">
                            <div class=""banner_text_iner"">
                                <h1>Casas de show</h1>
                                <p> Diversos afiliados ao nosso serviço conheça nossos serviços e compre agora seu ingresso.</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b8036decec6375e8f5b402d115fe2a3ef5ab635088", async() => {
                WriteLiteral("Compre seu ingresso agora");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- banner part start-->

        <!-- gallery_part part start-->
        <section class=""gallery_part section_padding"" id=""sobre"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-xl-5"">
                        <div class=""section_tittle text-center"">
                            <h2>Shows</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <div class=""gallery_part_item"">
                            <div class=""grid"">
                                <div class=""grid-sizer""></div>
                                <a href=""img/gallery/1.jpg""
                                    class=""grid-item bg_img img-gal grid-i");
            WriteLiteral(@"tem--height-1""
                                    style=""background-image: url('img/gallery/1.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                                <a href=""img/gallery/2.jpg"" class=""grid-item bg_img img-gal""
                                    style=""background-image: url('img/gallery/2.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                      ");
            WriteLiteral(@"                          <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                                <a href=""img/gallery/3.jpg"" class=""grid-item bg_img img-gal""
                                    style=""background-image: url('img/gallery/3.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                                <a href=""img/gallery/5.jpg""
                                    class=""grid-item bg_im");
            WriteLiteral(@"g img-gal grid-item--height-2""
                                    style=""background-image: url('img/gallery/5.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                                <a href=""img/gallery/7.jpg""
                                    class=""grid-item bg_img img-gal grid-item--height-2""
                                    style=""background-image: url('img/gallery/7.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                          ");
            WriteLiteral(@"                  <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                                <a href=""img/gallery/6.jpg""
                                    class=""grid-item bg_img img-gal grid-item--width-1""
                                    style=""background-image: url('img/gallery/6.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                            ");
            WriteLiteral(@"    </a>
                                <a href=""img/gallery/4.jpg""
                                    class=""grid-item bg_img img-gal sm_weight  grid-item--height-1""
                                    style=""background-image: url('img/gallery/4.jpg')"">
                                    <div class=""single_gallery_item"">
                                        <div class=""single_gallery_item_iner"">
                                            <div class=""gallery_item_text"">
                                                <i class=""ti-zoom-in""></i>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
