#pragma checksum "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b521f67182eaa3770f023a403d4e82857454292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\_ViewImports.cshtml"
using EasyWayGroceries;

#line default
#line hidden
#line 2 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\_ViewImports.cshtml"
using EasyWayGroceries.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b521f67182eaa3770f023a403d4e82857454292", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a514502a03597c9ed787c83d19072579ab90822", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyWayGroceries.Models.RegistrationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomeStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/fruit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fruitlogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imagelogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegistrationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ResetForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("ShowLogin()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b2e637c55e5498baafa5e399a55b5cf", async() => {
                BeginContext(58, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(64, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7a90e682f7346d2bf5a1d3c87117ca4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(132, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(143, 14863, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce16f35d008484a8aaf2dc19d69b4b8", async() => {
                BeginContext(170, 238, true);
                WriteLiteral("\r\n    <div class=\"modal fade\" id=\"ShowRegistration\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-body\">\r\n                    ");
                EndContext();
                BeginContext(408, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "459dbcf29cc44babacd73574db85623b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(458, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(480, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c14314376d2248d69daac0b81b0b4ed0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(529, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(551, 2051, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34c02d6107f45b88976ab7ece63306b", async() => {
                    BeginContext(579, 2016, true);
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <span id=""RegError""></span>
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                                <input class=""form-control"" type=""text"" name=""Username"" id=""RegUserName"" placeholder=""Username"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
                                <input class=""form-control"" type=""email"" name=""Email"" id=""RegEmail"" placeholder=""Email"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group"">
                            ");
                    WriteLiteral(@"    <span class=""input-group-addon""><i class=""glyphicon glyphicon-lock""></i></span>
                                <input class=""form-control"" type=""password"" name=""Password"" id=""RegPassword"" placeholder=""Password"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-lock""></i></span>
                                <input class=""form-control"" type=""password"" name=""ConfirmPassword"" id=""RegConfirmPassword"" placeholder=""Confirm Password"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <button type=""button"" class=""btn btn-info form-control"" id=""RegButton"" name=""SignUp"" onclick=""DoRegistration()"">SignUp</button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2602, 567, true);
                WriteLiteral(@"
                    <div class=""form-group"" id=""LoginLink"">
                        <label>Already Have Account?</label>
                        <a style=""cursor:pointer"" onclick=""ShowLogin()"">Login</a>
                    </div>
                </div>
            </div>
        </div>
        </div>
    
        <div class=""modal fade"" id=""ShowLogin"" data-keyboard=""false"" data-backdrop=""static"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-body"">
                        ");
                EndContext();
                BeginContext(3169, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72d686bc6b42417bb1b4495cd6210bf0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3219, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3245, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efb5812ee45b42f49297e2fc522ff872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3294, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3320, 1249, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e5b0a0b14e4f76bddcd220224f7a1f", async() => {
                    BeginContext(3341, 1221, true);
                    WriteLiteral(@"
                            <div class=""form-group"">
                                <span id=""LoginError""></span>
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
                                    <input class=""form-control"" type=""email"" name=""Email"" id=""LoginEmail"" placeholder=""Email"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""glyphicon glyphicon-lock""></i></span>
                                    <input class=""form-control"" type=""password"" name=""Password"" id=""LoginPassword"" placeholder=""Password"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                 ");
                    WriteLiteral("               <button class=\"btn btn-info form-control\" id=\"LoginButton\" type=\"button\" name=\"Login\" onclick=\"DoLogin()\">Login</button>\r\n                            </div>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4569, 856, true);
                WriteLiteral(@"
                        <div class=""form-group"" id=""RegistrationLink"">
                            <label>Don't have Account?</label>
                            <a style=""cursor:pointer"" onclick=""ShowRegistration()"">Sign Up</a>
                        </div>
                        <div class=""form-group"" id=""ResetLink"">
                            <label>Forget your password?</label>
                            <a style=""cursor:pointer"" onclick=""ShowResetPassword()"">Reset it</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
  
    <div class=""modal fade"" id=""ShowResetPassword"" data-keyboard=""false"" data-backdrop=""static"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(5425, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e165fb6f04d94ff38be691faa36ea8f3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5475, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5497, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce899ec0030b4d14bb15ae8ca4213cf2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5546, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5568, 770, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55333f90f50e4f7c96cd7681e6566891", async() => {
                    BeginContext(5589, 742, true);
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <span id=""ResetError""></span>
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
                                <input class=""form-control"" type=""email"" name=""Email"" id=""ResetEmail"" placeholder=""Email"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <button class=""btn btn-info form-control"" id=""ResetButton"" type=""button"" name=""Reset"" onclick=""DoResetpassword()"">Send Email</button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6338, 6859, true);
                WriteLiteral(@"
                 </div>
            </div>
        </div>
    </div>
    
    <script>
        var loginForm = document.getElementById(""LoginForm"");
        var registrationForm = document.getElementById(""RegistrationForm"");
        var resetForm = document.getElementById(""ShowResetPassword"");
        //login
        var loginEmail = document.getElementById(""LoginEmail"");
        var resetEmail = document.getElementById(""ResetEmail"");
        var loginPassword = document.getElementById(""LoginPassword"");
        var loginError = document.getElementById(""LoginError"");
        var resetError = document.getElementById(""ResetError"");


        //registartion
        var regUserName = document.getElementById(""RegUserName"");
        var regEmail = document.getElementById(""RegEmail"");
        var regPassword = document.getElementById(""RegPassword"");
        var regConfirmPassword = document.getElementById(""RegConfirmPassword"");
        var regError = document.getElementById(""RegError"");

   ");
                WriteLiteral(@"     function ShowRegistration() {
            regError.style.display = ""none"";
            $(""#ShowRegistration"").modal();
            $(""#ShowLogin"").modal('hide')
            loginForm.reset();
        }
        function ShowLogin() {
            loginError.style.display = ""none"";
            $(""#ShowLogin"").modal();
            $(""#ShowRegistration"").modal('hide');
            registrationForm.reset();

        }
        function ShowResetPassword() {
            resetError.style.display = ""none"";
            $(""#ShowResetPassword"").modal();
            $(""#ShowLogin"").modal('hide');
            loginForm.reset();

        }
        //--------------------LOGIN--------------------
        function DoLogin() {
            loginError.style.display = ""none"";

            if (loginEmail.value == """") {
                loginEmail.focus();
                loginError.style.display = ""block"";
                loginError.innerHTML = ""Please enter Email!"";
            }
            else if");
                WriteLiteral(@" (!validateEmail(loginEmail.value)) {
                loginEmail.focus();
                loginError.style.display = ""block"";
                loginError.innerHTML = ""Invalid Email!"";
            }
            else if (loginPassword.value == """") {
                loginPassword.focus();
                loginError.style.display = ""block"";
                loginError.innerHTML = ""Please enter Password!"";
            }
            else {
                document.body.style.cursor = 'wait';
                var data = { EmailId: $(""#LoginEmail"").val(), Password: $(""#LoginPassword"").val() };
                $.ajax({
                    type: 'post',
                    data: data,
                    dataType: ""json"",
                    url: ""/Home/Login"",
                    success: function (result) {
                        if (result == ""Success"") {
                            document.body.style.cursor = 'default';
                            window.location = ""/Dashboard/Welcome""
        ");
                WriteLiteral(@"                }
                        else if (result == ""Not Verified"") {
                            document.body.style.cursor = 'default';
                            loginError.style.display = ""block"";
                            loginError.innerHTML = ""Email not Verified! Please check your email for verification"";
                        }
                        else {
                            document.body.style.cursor = 'default';
                            loginError.style.display = ""block"";
                            loginError.innerHTML = ""Incorrect Email or Password!"";
                            //alert(""Incorrect Email Id or Password"");
                        }

                    }
                });
            }
        }
        //------------------------REGISTRATION-----------------------
        function DoRegistration() {
            regError.style.display = ""none"";
            if (regUserName.value == """") {
                regUserName.focus();
         ");
                WriteLiteral(@"       regError.style.display = ""block"";
                regError.innerHTML = ""Please enter User Name!"";
            }
            else if (regEmail.value == """") {
                regEmail.focus();
                regError.style.display = ""block"";
                regError.innerHTML = ""Please enter Email!"";
            }
            else if (!validateEmail(regEmail.value)) {
                regEmail.focus();
                regError.style.display = ""block"";
                regError.innerHTML = ""Invalid Email!"";
            }
            else if (regPassword.value == """") {
                regPassword.focus();
                regError.style.display = ""block"";
                regError.innerHTML = ""Please enter Password!"";
            }
            else if (regConfirmPassword.value == """") {
                regConfirmPassword.focus();
                regError.style.display = ""block"";
                regError.innerHTML = ""Please confirm Password!"";
            }
            else if (regConfirm");
                WriteLiteral(@"Password.value != regPassword.value) {
                regConfirmPassword.focus();
                regError.style.display = ""block"";
                regError.innerHTML = ""Passwords do not match!"";
            }
            else {
                document.body.style.cursor = 'wait';
                var data = { UserName: $(""#RegUserName"").val(), EmailId: $(""#RegEmail"").val(), Password: $(""#RegPassword"").val() };
                $.ajax({
                    type: 'post',
                    data: data,
                    dataType: 'json',
                    url: ""/Home/SaveRegistration"",
                    success: function (result) {
                        if (result == ""Duplicate"") {
                            document.body.style.cursor = 'default';
                            regEmail.focus();
                            regError.style.display = ""block"";
                            regError.innerHTML = ""Email already exist!"";
                        }
                        else if ");
                WriteLiteral(@"(result == ""Success"") {
                            document.body.style.cursor = 'default';
                            alert(""Registration successful!  A Verification email has been sent to your email address. Please verify your email. Click 'OK' to Login"")
                            ShowLogin();
                        }
                        else {
                            document.body.style.cursor = 'default';
                            alert(result);
                        }
                    }

                });
            }
        }
        //----------------EmailValidate-----------------------
        function validateEmail(email) {
            var expr = /^([\w-\.]+)");
                EndContext();
                BeginContext(13198, 1801, true);
                WriteLiteral(@"@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
            return expr.test(email);
        }
        //--------------------RESET---------------------
        function DoResetpassword() {
            resetError.style.display = ""none"";

            if (resetEmail.value == """") {
                resetEmail.focus();
                resetError.style.display = ""block"";
                resetError.innerHTML = ""Please enter Email!"";
            }
            else if (!validateEmail(resetEmail.value)) {
                resetEmail.focus();
                resetError.style.display = ""block"";
                resetError.innerHTML = ""Invalid Email!"";
            }
            else {
                document.body.style.cursor = 'wait';
                var data = { EmailId: $(""#ResetEmail"").val()};
                $.ajax({
                    type: 'post',
                    data: data,
                    dataType: ""json"",
                    url: ""/Home/R");
                WriteLiteral(@"esetLink"",
                    success: function (result) {
                        if (result == ""Success"") {
                            document.body.style.cursor = 'default';
                            alert(""Please check your email for reset link"");
                            window.location = ""/Home/Index""
                        }
                        else {
                            document.body.style.cursor = 'default';
                            ResetError.style.display = ""block"";
                            ResetError.innerHTML = ""Incorrect Email!"";
                            //alert(""Incorrect Email Id or Password"");
                        }

                    }
                });
            }
        }


    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15006, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyWayGroceries.Models.RegistrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
