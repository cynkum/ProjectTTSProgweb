#pragma checksum "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\TTS\tts72170101\Views\Registrasi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d46e8b843b3f09413764634ed8dca45dbd30572d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registrasi_Index), @"mvc.1.0.view", @"/Views/Registrasi/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registrasi/Index.cshtml", typeof(AspNetCore.Views_Registrasi_Index))]
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
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\TTS\tts72170101\Views\_ViewImports.cshtml"
using tts72170101;

#line default
#line hidden
#line 2 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\TTS\tts72170101\Views\_ViewImports.cshtml"
using tts72170101.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d46e8b843b3f09413764634ed8dca45dbd30572d", @"/Views/Registrasi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a408ebb7e7025482b5621d0c1581efee075173bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Registrasi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/TampilHasil/Tampil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\cyn\cynthiaa\kuliah SI\SEMESTER 4\ProgWeb\TTS\tts72170101\Views\Registrasi\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 30, true);
            WriteLiteral("\r\n<h2>Form Registrasi</h2>\r\n\r\n");
            EndContext();
            BeginContext(62, 1532, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46e8b843b3f09413764634ed8dca45dbd30572d4233", async() => {
                BeginContext(111, 1476, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""Firstname"">Firstname :</label>
        <input type=""text"" class=""form-control"" name=""Firstname"" />
    </div>
    <div class=""form-group"">
        <label for=""Lastname"">Lastname :</label>
        <input type=""text"" class=""form-control"" name=""Lastname"" />
    </div>
    <div class=""form-group"">
        <label for=""Address"">Address :</label>
        <input type=""text"" class=""form-control"" name=""Address"" />
    </div>
    <div class=""form-group"">
        <label for=""Gender"">Gender    :</label>&nbsp;&nbsp;
        <input type=""radio""  name=""Gender"" value=""Male""/><label for=""Male"">Male</label>&nbsp;&nbsp;&nbsp;
        <input type=""radio""  name=""Gender"" value=""Female""/><label for=""Female"">Female</label>          
    </div>
         <div class=""form-group"">
        <label for=""Telp"">Telp :</label>
        <input type=""text"" class=""form-control"" name=""Telp"" />
    </div>

    <div class=""form-group"">
        <label for=""Hobby"">Hobby    :</lab");
                WriteLiteral(@"el>&nbsp;&nbsp;
        <input type=""checkbox"" name=""Hobby"" value=""gaming""/><label for=""Gaming"">Gaming</label>&nbsp;&nbsp;&nbsp;
        <input type=""checkbox"" name=""Hobby2"" value=""watching movie""/><label for=""Watching Movie"">Watching Movie</label>&nbsp;&nbsp;&nbsp;
        <input type=""checkbox"" name=""Hobby3"" value=""cycling""/><label for=""Cycling"">Cycling</label>
    </div>
    
    <br/>
    <button class=""btn btn-primary"">Submit</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
