#pragma checksum "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/Views/Home/Daftar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4c8f5da7a1746761875b7209d96c6d3df2bd97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Daftar), @"mvc.1.0.view", @"/Views/Home/Daftar.cshtml")]
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
#line 1 "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/Views/_ViewImports.cshtml"
using Warungcd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/Views/_ViewImports.cshtml"
using Warungcd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4c8f5da7a1746761875b7209d96c6d3df2bd97", @"/Views/Home/Daftar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88e572666c66c08e14ff2004ac3dd2877e29c90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Daftar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/Views/Home/Daftar.cshtml"
  
    ViewData["Title"] = "Daftar Akun";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/Views/Home/Daftar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4c8f5da7a1746761875b7209d96c6d3df2bd974661", async() => {
                WriteLiteral("\r\n  <fieldset>\r\n    <div class=\"control-group\">\r\n      <!-- Username -->\r\n      <label class=\"control-label\"  for=\"username\">Username</label>\r\n      <div class=\"controls\">\r\n        <input type=\"text\" id=\"username\" name=\"username\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 361, "\"", 375, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-xlarge"">
        <p class=""help-block"">Username tidak boleh menggunakan spasi</p>
      </div>
    </div>
 
    <div class=""control-group"">
      <!-- E-mail -->
      <label class=""control-label"" for=""email"">E-mail</label>
      <div class=""controls"">
        <input type=""text"" id=""email"" name=""email""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 702, "\"", 716, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-xlarge"">
        <p class=""help-block"">Masukkan E-mail anda</p>
      </div>
    </div>
 
    <div class=""control-group"">
      <!-- Password-->
      <label class=""control-label"" for=""password"">Password</label>
      <div class=""controls"">
        <input type=""password"" id=""password"" name=""password""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1041, "\"", 1055, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-xlarge"">
        <p class=""help-block"">Password setidaknya menggunakan minimal 4 karakter</p>
      </div>
    </div>
 
    <div class=""control-group"">
      <!-- Password -->
      <label class=""control-label""  for=""password_confirm"">Password (Konfirmasi)</label>
      <div class=""controls"">
        <input type=""password"" id=""password_confirm"" name=""password_confirm""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1449, "\"", 1463, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-xlarge"">
        <p class=""help-block"">Konfirmasi Password</p>
      </div>
    </div>
 
    <div class=""control-group"">
      <!-- Button -->
      <div class=""controls"">
        <button class=""btn btn-primary"">Daftar</button>
      </div>
    </div>
  </fieldset>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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