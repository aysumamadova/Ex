#pragma checksum "C:\Users\tu7tw2d21\source\repos\exam\exam\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2386ec73b94f846bc2010e60d74b7f6a3800f86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\tu7tw2d21\source\repos\exam\exam\Views\_ViewImports.cshtml"
using exam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7tw2d21\source\repos\exam\exam\Views\_ViewImports.cshtml"
using exam.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7tw2d21\source\repos\exam\exam\Views\_ViewImports.cshtml"
using exam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2386ec73b94f846bc2010e60d74b7f6a3800f86d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a259d25003680caae5364018f94e65a7c78346", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2386ec73b94f846bc2010e60d74b7f6a3800f86d3390", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.9.2/dist/umd/popper.min.js"" integrity=""sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"" integrity=""sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""/../assets/css/style.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
    <link rel=""stylesheet"" href=""https://www.w3schools");
                WriteLiteral(".com/w3css/4/w3.css\">\r\n    <title>Document</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2386ec73b94f846bc2010e60d74b7f6a3800f86d5510", async() => {
                WriteLiteral(@"
    <nav>
        <div class=""w3-sidebar w3-bar-block w3-card w3-animate-right"" style=""display:none;right:0;"" id=""rightMenu"">
            <button onclick=""closeRightMenu()"" class=""w3-bar-item w3-button w3-large"">Close &times;</button>
            <a href=""#"" class=""w3-bar-item w3-button"">Link 1</a>
            <a href=""#"" class=""w3-bar-item w3-button"">Link 2</a>
            <a href=""#"" class=""w3-bar-item w3-button"">Link 3</a>
        </div>

        <div class=""w3-teal"">
            <button class=""w3-button w3-teal w3-xlarge w3-right"" onclick=""openRightMenu()"">&#9776;</button>
        </div>
        </div>
        <div class=""home text-center"">
            <h1 class=""display-5 fw-bold"">Welcome to Meal</h1><br>
            <div class=""col-lg-6 mx-auto"">
                <div class=""d-grid gap-2 d-sm-flex justify-content-sm-center"">
                    <button type=""button"" class=""btn btn-outline-light btn-lg"">Reseve a table</button>
                </div>
            </div>
        </div>
");
                WriteLiteral("    </nav>\r\n    ");
#nullable restore
#line 37 "C:\Users\tu7tw2d21\source\repos\exam\exam\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <footer class=\"text-center text-lg-start bg-dark text-muted\">\r\n\r\n        <section");
                BeginWriteAttribute("class", " class=\"", 2272, "\"", 2280, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""container text-center text-md-start mt-5"">
                <!-- Grid row -->
                <div class=""row mt-3"">
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                        <!-- Content -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            <i class=""fas fa-gem me-3""></i>Company name
                        </h6>
                        <p>
                            Here you can use rows and columns to organize your footer content. Lorem ipsum
                            dolor sit amet, consectetur adipisicing elit.
                        </p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
              ");
                WriteLiteral(@"              Products
                        </h6>
                        <p>
                            <a href=""#!"" class=""text-reset"">Angular</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">React</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Vue</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Laravel</a>
                        </p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Useful links
                        </h6>
                        <p>
                            <a href=""#!"" class=""text");
                WriteLiteral(@"-reset"">Pricing</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Settings</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Orders</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Help</a>
                        </p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Contact
                        </h6>
                        <p><i class=""fas fa-home me-3""></i> New York, NY 10012, US</p>
                        <p>
                            <i class=""fas fa-envelope me-3""></i>
                            ");
                WriteLiteral(@"info@example.com
                        </p>
                        <p><i class=""fas fa-phone me-3""></i> + 01 234 567 88</p>
                        <p><i class=""fas fa-print me-3""></i> + 01 234 567 89</p>
                    </div>
                    <!-- Grid column -->
                </div>
                <!-- Grid row -->
            </div>
        </section>
        <!-- Section: Links  -->
        <!-- Copyright -->
        <div class=""text-center p-4"" style=""background-color: rgba(0, 0, 0, 0.05);"">
            ?? 2021 Copyright:
            <a class=""text-reset fw-bold"" href=""https://mdbootstrap.com/"">MDBootstrap.com</a>
        </div>
        <!-- Copyright -->
    </footer>
    <script src=""/../assets/js/main.js""></script>
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
            WriteLiteral("\r\n</html>\r\n");
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
