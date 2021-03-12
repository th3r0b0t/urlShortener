#pragma checksum "/home/shahab/Desktop/urlShortner/pages/shared/commonTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a76f92e3578b8ff1fc4998bbb65afec6dcd9874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_shared_commonTags), @"mvc.1.0.view", @"/pages/shared/commonTags.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a76f92e3578b8ff1fc4998bbb65afec6dcd9874", @"/pages/shared/commonTags.cshtml")]
    public class pages_shared_commonTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a76f92e3578b8ff1fc4998bbb65afec6dcd98742669", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>URL Shortner</title>
    <link rel=""stylesheet"" href=""Static_assets/css/bootstrap.min.css"">

    <style>
        /* =================================== */
        /*             Font Faces              */
        /* =================================== */

        ");
                WriteLiteral("@font-face {\n            font-family: Fira Code;\n            src: url(\'Static_assets/fonts/FiraCode-Variable.ttf\') format(\'truetype\');\n            font-weight: normal;\n            font-style: normal;\n        }\n\n        ");
                WriteLiteral(@"@font-face {
            font-family: Fira Code;
            src: url('Static_assets/fonts/FiraCode-Variable.ttf') format('truetype');
            font-weight: bold;
            font-style: normal;
        }

        /* =================================== */
        /*           End Font Faces            */
        /* =================================== */

        html,
        body {
            /* background-color: #2d2d2d; */
            background: #2d2d2d url(""Static_assets/img/ocean.jpg"") repeat;
            height: 100%;
            width: 100%;
            margin: 0;
            font-family: 'Fira Code', monospace;
        }

        .container-fluid {
            padding: 0;
            overflow-x: hidden;
        }

        /* ---- End container-fluid ---- */

        .input-container {
            text-align: center;
            padding-top: 40vh;
        }

        /* ---- End input-container ---- */

        #url-input {
            background-color: #1c1b1b;
            opacity: 0.7;
          ");
                WriteLiteral(@"  color: #E07400;
            border-radius: 2rem;
            border: 0.2rem solid #E07400;
            height: 2.5rem;
            width: 80vw;
            text-align: center;
            transition: all ease-in-out 500ms;
        }

        #url-input:focus {
            outline: none;
            opacity: 1;
            /*border-color: #1f8bff;*/
        }

        /* ---- End url-input ---- */

        #submit-btn {
            margin-top: 2rem;
            width: 20vw;
            padding: 0.5rem 0;
            background-color: #E07400;
            border: none;
            border-radius: 2rem;
        }

        #submit-btn:focus {
            outline: none;
        }
        /* ---- End submit-btn ---- */

        .url-data{
            margin-left: 10vw;
        }
        /* ---- End url-data ---- */        
        
        .card{
            border-radius: 0.5rem;
            margin-top: 30vh;
            width: 70vw;
        }

        .card-header{
            background: #E07400;
            bo");
                WriteLiteral(@"rder-radius: 0.5rem 0.5rem 0 0;
        }

        .card-body{
            background: #2d2d2d;
            color: white;
            border-radius: 0 0 0.5rem 0.5rem;
        }

        .card-body h5 a{
            text-decoration: none;
        }
        /* ---- End card ---- */

    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a76f92e3578b8ff1fc4998bbb65afec6dcd98746783", async() => {
                WriteLiteral("\n\n    <div class=\"container-fluid\">\n\n");
                WriteLiteral("                ");
#nullable restore
#line 126 "/home/shahab/Desktop/urlShortner/pages/shared/commonTags.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("\n    </div>\n\n\n\n    <script src=\"Static_assets/js/jquery.min.js\"></script>\n    <script src=\"Static_assets/js/popper.min.js\"></script>\n    <script src=\"Static_assets/js/bootstrap.min.js\"></script>\n");
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
