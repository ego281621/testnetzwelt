#pragma checksum "C:\Development\greenova\Netzwelt\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67da2c954a2d06404360292bc806d07dfc87d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Development\greenova\Netzwelt\Views\_ViewImports.cshtml"
using Netzwelt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\greenova\Netzwelt\Views\_ViewImports.cshtml"
using Netzwelt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67da2c954a2d06404360292bc806d07dfc87d29", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef06e32ddc538949a196d59c35b083b80205bef0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Development\greenova\Netzwelt\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67da2c954a2d06404360292bc806d07dfc87d293368", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        ul, #myUL {
            list-style-type: none;
        }

        #myUL {
            margin: 0;
            padding: 0;
        }

        .caret {
            cursor: pointer;
            -webkit-user-select: none; /* Safari 3.1+ */
            -moz-user-select: none; /* Firefox 2+ */
            -ms-user-select: none; /* IE 10+ */
            user-select: none;
        }

            .caret::before {
                content: ""\25B6"";
                color: black;
                display: inline-block;
                margin-right: 6px;
            }

        .caret-down::before {
            -ms-transform: rotate(90deg); /* IE 9 */
            -webkit-transform: rotate(90deg); /* Safari */
            ' transform: rotate(90deg);
        }

        .nested {
            display: none;
        }

        .active {
            display: block;
        }
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67da2c954a2d06404360292bc806d07dfc87d295350", async() => {
                WriteLiteral(@"
    <h2>Territories</h2>
    <p>Here are the list of territories</p>
    <ul id=""myUL"">
        <li>
            <span class=""caret"">Central Luzon</span>
            <ul class=""nested"">
                <li>Bulacan</li>
                <li>Nueva Ecija</li>
                <li>Pampanga</li>
                <li>Tarlac</li>
            </ul>
        </li>
        <li>
            <span class=""caret"">Metro Manila</span>
            <ul class=""nested"">
                <li>
                    <span class=""caret"">Makati</span>
                    <ul class=""nested"">
                        <li>Poblacion</li>
                        <li>Bel-Air</li>
                        <li>Urdaneta</li>
                    </ul>
                </li>
                <li>
                    <span class=""caret"">Marikina</span>
                    <ul class=""nested"">
                        <li>
                            <span class=""caret"">Malanday</span>
                            <ul class=""neste");
                WriteLiteral(@"d"">
                                <li>Lamuan</li>
                                <li>Sta. Teresita</li>
                                <li>Malaya</li>
                            </ul>
                        </li>
                        <li>San Roque</li>
                        <li>Concepcion</li>
                    </ul>
                </li>
                <li>Manila</li>
            </ul>
        </li>
        <li>
            <span class=""caret"">CALABARZON</span>
            <ul class=""nested"">
                <li>
                    <span class=""caret"">Batangas</span>
                    <ul class=""nested"">
                        <li>Lipa</li>
                        <li>Bauan</li>
                        <li>Sto. Tomas</li>
                    </ul>
                </li>
                <li>
                    <span class=""caret"">Cavite</span>
                    <ul class=""nested"">
                        <li>Silang</li>
                        <li>Bacoor</li>
 ");
                WriteLiteral(@"                       <li>Imus</li>
                        <li>Kawit</li>
                    </ul>
                </li>
                <li>
                    <span class=""caret"">Laguna</span>
                    <ul class=""nested"">
                        <li>Calamba</li>
                        <li>Sta. Rosa</li>
                        <li>San Pedro</li>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
    <script>
        var toggler = document.getElementsByClassName(""caret"");
        var i;
        for (i = 0; i < toggler.length; i++) {
            toggler[i].addEventListener(""click"", function () {
                this.parentElement.querySelector("".nested"").classList.toggle(""active"");
                this.classList.toggle(""caret-down"");
            });
        }
    </script>
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
