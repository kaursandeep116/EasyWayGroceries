#pragma checksum "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fa6595be5ecf618a99ee1a1bb1235b702d7362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ProductDetails), @"mvc.1.0.view", @"/Views/Dashboard/ProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/ProductDetails.cshtml", typeof(AspNetCore.Views_Dashboard_ProductDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86fa6595be5ecf618a99ee1a1bb1235b702d7362", @"/Views/Dashboard/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a514502a03597c9ed787c83d19072579ab90822", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyWayGroceries.Models.ProductsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ProductDetailsStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(51, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4ae0b9b1b814d06b0c2ceef6e504fe1", async() => {
                BeginContext(57, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(67, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31e44f40cfad43479bd3568e34905894", async() => {
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
                BeginContext(145, 129, true);
                WriteLiteral("\r\n        <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
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
            BeginContext(281, 112, true);
            WriteLiteral("\r\n<div id=\"header_div\">\r\n</div>\r\n<div id=\"ContainerDiv\">\r\n    <div id=\"leftDiv\">\r\n        <img id=\"ProductImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 393, "\"", 428, 1);
#line 10 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
WriteAttributeValue("", 399, Url.Content(Model.ImagePath), 399, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(429, 98, true);
            WriteLiteral(" />\r\n\r\n    </div>\r\n    <div id=\"rightDiv\">\r\n\r\n        <label id=\"ProductName\" data-toggle=\"modal\">");
            EndContext();
            BeginContext(528, 17, false);
#line 15 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
                                               Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(545, 80, true);
            WriteLiteral("</label><br />\r\n        <div id=\"PriceUnitDiv\">\r\n            <label id=\"Price\">$");
            EndContext();
            BeginContext(626, 11, false);
#line 17 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(637, 44, true);
            WriteLiteral(" per</label>\r\n            <label id=\"Unit\"> ");
            EndContext();
            BeginContext(682, 10, false);
#line 18 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
                         Write(Model.Unit);

#line default
#line hidden
            EndContext();
            BeginContext(692, 70, true);
            WriteLiteral("</label><br />\r\n        </div>\r\n        <label id=\"Desc\">Description: ");
            EndContext();
            BeginContext(763, 17, false);
#line 20 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
                                 Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(780, 1273, true);
            WriteLiteral(@"</label><br />
        <span id=""QuantityError"" style=""display: none""></span>
        <input class=""form-control"" type=""number"" name=""quantity"" id=""Quantity"" min=""1"" max=""50"" placeholder=""Add Quantity"" onkeyup=""EditButton()""/>
        <button type=""button"" class=""btn btn-info form-control"" id=""AddCart"" name=""AddCart"" onclick=""AddItemToCart()"">
         Add to Cart</button>
        <button type=""button"" class=""btn btn-info form-control"" id=""GoBack"" name=""GoBack"" onclick=""GoBack()""> << Go Back To List</button>
    </div>
</div>
<script>
    function AddItemToCart() {
        
        var Quantity = document.getElementById(""Quantity"");
        var ErrorSpan = document.getElementById(""QuantityError"");
        var AddCart = document.getElementById(""AddCart"");
        if (Quantity.value == """") {
            Quantity.focus();
            ErrorSpan.style.display = ""block"";
            ErrorSpan.innerHTML = ""Please enter Quantity!"";
        }
        else if (parseInt(Quantity.value) < 0) {
       ");
            WriteLiteral("     Quantity.focus();\r\n            ErrorSpan.style.display = \"block\";\r\n            ErrorSpan.innerHTML = \"Quantity cannot be Negative!\";\r\n        }\r\n        else {\r\n            ErrorSpan.style.display = \"none\";\r\n            var data = { ProductId: ");
            EndContext();
            BeginContext(2054, 15, false);
#line 46 "D:\ComIT\EasywayGroceries\EasyWayGroceries\Views\Dashboard\ProductDetails.cshtml"
                               Write(Model.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2069, 674, true);
            WriteLiteral(@", Quantity: $(""#Quantity"").val() };
            $.ajax({
                type: 'post',
                data: data,
                dataType: ""json"",
                url: ""/Dashboard/AddToCart"",
                success: function (result) {
                    if (result == ""Success"") {
                        var text = $(""#Quantity"").val() + "" "" + $(""#Unit"").text() + "" in cart"";
                        AddCart.innerText = text;
                    }

                }
            });
        }
    }
    function GoBack() {
        window.history.back();
    }
    function EditButton() {
        AddCart.innerText = ""Add to Cart"";
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyWayGroceries.Models.ProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591