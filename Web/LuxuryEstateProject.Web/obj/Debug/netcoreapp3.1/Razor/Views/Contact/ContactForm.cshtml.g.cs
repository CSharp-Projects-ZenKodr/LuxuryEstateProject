#pragma checksum "C:\Users\danie\Documents\GitHub\LuxuryEstateProject-main\Web\LuxuryEstateProject.Web\Views\Contact\ContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0aebbcc8d9311959542f8a6dcaec75226c2442f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactForm), @"mvc.1.0.view", @"/Views/Contact/ContactForm.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\LuxuryEstateProject-main\Web\LuxuryEstateProject.Web\Views\_ViewImports.cshtml"
using LuxuryEstateProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\LuxuryEstateProject-main\Web\LuxuryEstateProject.Web\Views\_ViewImports.cshtml"
using LuxuryEstateProject.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0aebbcc8d9311959542f8a6dcaec75226c2442f", @"/Views/Contact/ContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4432b5840e5063822c5424e246be6fe829f294be", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aebbcc8d9311959542f8a6dcaec75226c2442f5421", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\n\n    <title>EstateAgency Bootstrap Template - Index</title>\n    <meta");
                BeginWriteAttribute("content", " content=\"", 212, "\"", 222, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"descriptison\">\n    <meta");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"keywords\">\n\n    <!-- Google Fonts -->\n    <link href=\"https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700\" rel=\"stylesheet\">\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aebbcc8d9311959542f8a6dcaec75226c2442f7072", async() => {
                WriteLiteral(@"

    <main id=""main"">

        <!-- ======= Intro Single ======= -->
        <section class=""intro-single"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12 col-lg-8"">
                        <div class=""title-single-box"">
                            <h1 class=""title-single"">Contact US</h1>
                            <span class=""color-text-a"">You can connect with us any time of the day !</span>
                        </div>
                    </div>
                    <div class=""col-md-12 col-lg-4"">
                        <nav aria-label=""breadcrumb"" class=""breadcrumb-box d-flex justify-content-lg-end"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aebbcc8d9311959542f8a6dcaec75226c2442f8184", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">
                                    Contact
                                </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section><!-- End Intro Single-->
        <!-- ======= Contact Single ======= -->
        <section class=""contact"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""contact-map box"">
                            <div id=""map"" class=""contact-map"">
                                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3022.1422937950147!2d-73.98731968482413!3d40.75889497932681!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c25855c6480299%3A0x55194ec5a1ae072e!2sTimes+Square!5e0!3m2!1ses-419!2sve!4v1510329142834"" width=""800"" height=""45");
                WriteLiteral(@"0"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-12 section-t8"">
                        <div class=""row"">
                            <div class=""col-md-7"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aebbcc8d9311959542f8a6dcaec75226c2442f11041", async() => {
                    WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-md-6 mb-3"">
                                            <div class=""form-group"">
                                                <input type=""text"" name=""name"" class=""form-control form-control-lg form-control-a"" placeholder=""Your Name"" data-rule=""minlen:4"" data-msg=""Please enter at least 4 chars"">
                                                <div class=""validate""></div>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 mb-3"">
                                            <div class=""form-group"">
                                                <input name=""email"" type=""email"" class=""form-control form-control-lg form-control-a"" placeholder=""Your Email"" data-rule=""email"" data-msg=""Please enter a valid email"">
                                                <div class=""validate""></div>
          ");
                    WriteLiteral(@"                                  </div>
                                        </div>
                                        <div class=""col-md-12 mb-3"">
                                            <div class=""form-group"">
                                                <input type=""text"" name=""subject"" class=""form-control form-control-lg form-control-a"" placeholder=""Subject"" data-rule=""minlen:4"" data-msg=""Please enter at least 8 chars of subject"">
                                                <div class=""validate""></div>
                                            </div>
                                        </div>
                                        <div class=""col-md-12"">
                                            <div class=""form-group"">
                                                <textarea name=""message"" class=""form-control"" name=""message"" cols=""45"" rows=""8"" data-rule=""required"" data-msg=""Please write something for us"" placeholder=""Message""></textarea>
                                    ");
                    WriteLiteral(@"            <div class=""validate""></div>
                                            </div>
                                        </div>
                                        <div class=""col-md-12 mb-3"">
                                            <div class=""mb-3"">
                                                <div class=""loading"">Loading</div>
                                                <div class=""error-message""></div>
                                                <div class=""sent-message"">Your message has been sent. Thank you!</div>
                                            </div>
                                        </div>

                                        <div class=""col-md-12 text-center"">
                                            <button type=""submit"" class=""btn btn-a"">Send Message</button>
                                        </div>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""col-md-5 section-md-t3"">
                                <div class=""icon-box section-b2"">
                                    <div class=""icon-box-icon"">
                                        <span class=""ion-ios-paper-plane""></span>
                                    </div>
                                    <div class=""icon-box-content table-cell"">
                                        <div class=""icon-box-title"">
                                            <h4 class=""icon-title"">Say Hello</h4>
                                        </div>
                                        <div class=""icon-box-content"">
                                            <p class=""mb-1"">
                                                Email.
                                                <span class=""color-a"">daniel.todorow1@gmail.com</span>
                                            </p>
                                            <p class=");
                WriteLiteral(@"""mb-1"">
                                                Phone.
                                                <span class=""color-a"">+(359) 6797550</span>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""icon-box section-b2"">
                                    <div class=""icon-box-icon"">
                                        <span class=""ion-ios-pin""></span>
                                    </div>
                                    <div class=""icon-box-content table-cell"">
                                        <div class=""icon-box-title"">
                                            <h4 class=""icon-title"">Find us in</h4>
                                        </div>
                                        <div class=""icon-box-content"">
                                            <p class=""mb-1"">
                                   ");
                WriteLiteral(@"             Sofia, Bulgaria
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""icon-box"">
                                    <div class=""icon-box-icon"">
                                        <span class=""ion-ios-redo""></span>
                                    </div>
                                    <div class=""icon-box-content table-cell"">
                                        <div class=""icon-box-title"">
                                            <h4 class=""icon-title"">Social networks</h4>
                                        </div>
                                        <div class=""icon-box-content"">
                                            <div class=""socials-footer"">
                                                <ul class=""list-inline"">
                                                    <li class=""list-inline-item"">");
                WriteLiteral(@"
                                                        <a href=""http://www.facebook.com/"">
                                                            <i class=""fa fa-facebook"" aria-hidden=""true""></i>
                                                        </a>
                                                    </li>
                                                    <li class=""list-inline-item"">
                                                        <a href=""https://twitter.com"">
                                                            <i class=""fa fa-twitter"" aria-hidden=""true""></i>
                                                        </a>
                                                    </li>
                                                    <li class=""list-inline-item"">
                                                        <a href=""http://www.instagram.com"">
                                                            <i class=""fa fa-instagram"" aria-hidden=""true""></i>
                    ");
                WriteLiteral(@"                                    </a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section><!-- End Contact Single-->

    </main><!-- End #main -->

    <a href=""#"" class=""back-to-top""><i class=""fa fa-chevron-up""></i></a>
    <div id=""preloader""></div>

");
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
            WriteLiteral("\n\n</html>");
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