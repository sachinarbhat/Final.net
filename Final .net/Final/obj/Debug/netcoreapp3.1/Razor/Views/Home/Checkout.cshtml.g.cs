#pragma checksum "C:\Users\Dell\Downloads\Final\Final .net\Final\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df8b5d6c0ddbb86f7fdeb6aaa7ade445ef41ed9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
#line 1 "C:\Users\Dell\Downloads\Final\Final .net\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8b5d6c0ddbb86f7fdeb6aaa7ade445ef41ed9f", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290a17bd353bae3a5dee2e0d6b736af977ac2359", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\Downloads\Final\Final .net\Final\Views\Home\Checkout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df8b5d6c0ddbb86f7fdeb6aaa7ade445ef41ed9f3716", async() => {
                WriteLiteral(@"
    <title>Checkout</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <style>
        body {
            font-family: Arial;
            font-size: 17px;
            padding: 8px;
            background-color: black;
        }

        * {
            box-sizing: border-box;
        }

        .row {
            display: -ms-flexbox;

            display: flex;
            -ms-flex-wrap: wrap;

            flex-wrap: wrap;
            margin: 0 -16px;
        }

        .col-25 {
            -ms-flex: 25%;

            flex: 25%;
        }

        .col-50 {
            -ms-flex: 50%;

            fle");
                WriteLiteral(@"x: 50%;
        }

        .col-75 {
            -ms-flex: 75%;

            flex: 75%;
        }

        .col-25,
        .col-50,
        .col-75 {
            padding: 0 16px;
        }

        ab {
            background-color: #2196F3;
        }


        .container {
            background-color: #121b21;
            padding: 5px 20px 15px 20px;
            border: 1px solid #243342;
            border-radius: 3px;
            color: gray;
        }

        input[type=text] {
            width: 100%;
            margin-bottom: 20px;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        label {
            margin-bottom: 10px;
            display: block;
        }

        .icon-container {
            margin-bottom: 20px;
            padding: 7px 0;
            font-size: 24px;
        }

        .fbtn {
            background-color: #2d4052;
            color: white;
            padding: 12p");
                WriteLiteral(@"x;
            margin: 10px 0;
            border: none;
            width: 100%;
            border-radius: 3px;
            cursor: pointer;
            font-size: 17px;
        }

            .fbtn:hover {
                background-color: #2b3b2b;
            }

        a {
            color: #2196F3;
        }

        hr {
            border: 1px solid lightgrey;
        }

        span.price {
            float: right;
            color: grey;
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df8b5d6c0ddbb86f7fdeb6aaa7ade445ef41ed9f7325", async() => {
                WriteLiteral(@"

    <h2 style=""text-align: center; color:lightgray;"">Enter The Details To Deliver</h2>
    <div class=""row"">
        <div class=""col-75"">
            <div class=""container"">


                <div class=""row"">
                    <div class=""col-50"">
                        <h3>Billing Address</h3>
                        <label for=""fname""><i class=""fa fa-user""></i> Full Name</label>
                        <input type=""text"" id=""fname"" name=""firstname"" placeholder=""Enter receiver name"">
                        <label for=""email""><i class=""fa fa-envelope""></i> Email</label>
                        <input type=""text"" id=""email"" name=""email"" placeholder=""Enter mail id"">
                        <label for=""adr""><i class=""fa fa-address-card-o""></i> Address</label>
                        <input type=""text"" id=""adr"" name=""address"" placeholder=""eg: House No/Flat No,Street etc..."">
                        <label for=""city""><i class=""fa fa-institution""></i> City</label>
                        <i");
                WriteLiteral(@"nput type=""text"" id=""city"" name=""city"" placeholder=""Enter the city"">

                        <div class=""row"">
                            <div class=""col-50"">
                                <label for=""state"">State</label>
                                <input type=""text"" id=""state"" name=""state"" placeholder=""Enter the state"">
                            </div>
                            <div class=""col-50"">
                                <label for=""zip"">Pin Code</label>
                                <input type=""text"" id=""zip"" name=""zip"" placeholder=""eg: 100201"">
                            </div>
                        </div>
                    </div>

                    <div class=""col-50"">
                        <h3>Payment Mode</h3>
                        <label for=""cname"">Choose your payment method</label>
                        <input type=""checkbox"" class=""btn-check"" id=""btn-check-outlined"" autocomplete=""off"">
                        <label class=""btn btn-outline-prima");
                WriteLiteral(@"ry"" for=""btn-check-outlined"">Cash On Delivery</label>
                        <p>
                            Due to high demand Cash on Delivery is available,Every social distancing protocal will be
                            taken care by our associate, UPI  <i class=""fa fa-qrcode"" aria-hidden=""true""></i> and cards <i class=""fa fa-cc-visa"" style=""color:navy;""></i>
                            <i class=""fa fa-cc-amex"" style=""color:blue;""></i>
                            <i class=""fa fa-cc-mastercard"" style=""color:red;""></i> are allowed.
                        </p>
                        <br>
                        <br> <br> <br> <br> <br> <br> <br>
                        <p style=""color: blue;"">Free Delivery</p>
                        <button style=""background-color: #090e11;"" disabled>
                            <img src=""https://thumbs.dreamstime.com/b/web-207131366.jpg""
                                 style=""width: 30%;"">
                        </button>
                    </div>
");
                WriteLiteral("\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df8b5d6c0ddbb86f7fdeb6aaa7ade445ef41ed9f10929", async() => {
                    WriteLiteral("<button onclick=\"fun()\" type=\"submit\" class=\"fbtn\">Procced</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <script>\r\n                    function fun() {\r\n                        alert(\"Thank you for your shoping Your order is placed\");\r\n                    }\r\n                </script>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
