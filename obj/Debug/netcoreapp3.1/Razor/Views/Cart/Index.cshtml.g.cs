#pragma checksum "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e21707ea7bb848abd925a202eca7eba2dad8815"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\haris\Source\Repos\ImageCRUD\Views\_ViewImports.cshtml"
using ImageCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\haris\Source\Repos\ImageCRUD\Views\_ViewImports.cshtml"
using ImageCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e21707ea7bb848abd925a202eca7eba2dad8815", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd53ec86a2f89fee731aef99cf20a23287749bd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImageCRUD.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link-secondary small text-uppercase mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    float sum = 0;
    float vat = 1.13F;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e21707ea7bb848abd925a202eca7eba2dad88155776", async() => {
                WriteLiteral(@"


    <!--Section: Block Content-->
    <section>

        <!--Grid row-->
        <div class=""row"">

            <!--Grid column-->
            <div class=""col-lg-8"">

                <!-- Card -->
                <div class=""mb-3"">
                    <div class=""pt-4 wish-list"">

                        <h5 class=""mb-4"">Cart (<span>");
#nullable restore
#line 25 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                                Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> items)</h5>\r\n");
#nullable restore
#line 26 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                         if (Model.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h2>Your cart is empty. Please select some items</h2>\r\n");
#nullable restore
#line 29 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                         foreach (var obj in Model)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""row mb-4"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""view zoom overlay z-depth-1 rounded mb-3 mb-md-0"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e21707ea7bb848abd925a202eca7eba2dad88157710", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1203, "~/Image/", 1203, 8, true);
#nullable restore
#line 37 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1211, obj.product_image, 1211, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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


                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div>
                                        <div class=""d-flex justify-content-between"">
                                            <div>
                                                <h5>");
#nullable restore
#line 47 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                               Write(obj.product_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                                <p class=\"mb-3 text-muted text-uppercase small\">Genre - ");
#nullable restore
#line 48 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                                                                                   Write(obj.Category.category_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral(@"                                            </div>
                                            <div>
                                                <div class=""def-number-input number-input safari_only mb-0 w-100"">
                                                    <button onclick=""this.parentNode.querySelector('input[type=number]').stepDown()""
                                                            class=""minus decrease""></button>
                                                    <input class=""quantity"" min=""0"" name=""quantity"" value=""1"" type=""number"">
                                                    <button onclick=""this.parentNode.querySelector('input[type=number]').stepUp()""
                                                            class=""plus increase""></button>
                                                </div>
                                                <small id=""passwordHelpBlock"" class=""form-text text-muted text-center"">
                                                 ");
                WriteLiteral(@"   (Note, 1 piece)
                                                </small>
                                            </div>
                                        </div>
                                        <div class=""d-flex justify-content-between align-items-center"">
                                            <div>
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e21707ea7bb848abd925a202eca7eba2dad881512006", async() => {
                    WriteLiteral("\r\n                                                    <i class=\"fas fa-trash-alt mr-1\"></i> Remove item\r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                                                         WriteLiteral(obj.product_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                                            </div>\r\n                                            <p class=\"mb-0\"><span><strong id=\"summary\">$");
#nullable restore
#line 74 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                                                                   Write(obj.product_price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span></p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 79 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"


                            sum += obj.product_price;


                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <p class=""text-primary mb-0"">
                            <i class=""fas fa-info-circle mr-1""></i> Do not delay the purchase, adding
                            items to your cart does not mean booking them.
                        </p>

                    </div>
                </div>
                <!-- Card -->
                <!-- Card -->
                <div class=""mb-3"">
                    <div class=""pt-4"">

                        <h5 class=""mb-4"">Expected shipping delivery</h5>

                        <p class=""mb-0""> Thu., 12.03. - Mon., 16.03.</p>
                    </div>
                </div>
                <!-- Card -->
                <!-- Card -->
                <div class=""mb-3"">
                    <div class=""pt-4"">

                        <h5 class=""mb-4"">We accept</h5>

                        <img class=""mr-2"" width=""45px""
                             src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/a");
                WriteLiteral(@"ssets/images/visa.svg""
                             alt=""Visa"">
                        <img class=""mr-2"" width=""45px""
                             src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/amex.svg""
                             alt=""American Express"">
                        <img class=""mr-2"" width=""45px""
                             src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/mastercard.svg""
                             alt=""Mastercard"">
                        <img class=""mr-2"" width=""45px""
                             src=""https://mdbootstrap.com/wp-content/plugins/woocommerce/includes/gateways/paypal/assets/images/paypal.png""
                             alt=""PayPal acceptance mark"">
                    </div>
                </div>
                <!-- Card -->

            </div>
            <!--Grid column-->
            <!--Grid column-->
            <div class=""col-lg-4"">

                ");
                WriteLiteral(@"<!-- Card -->
                <div class=""mb-3"">
                    <div class=""pt-4"">



                        <h5 class=""mb-3"">The total amount of</h5>

                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0"">
                                Temporary amount
                                <span>$ ");
#nullable restore
#line 143 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                   Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center px-0"">
                                Shipping
                                <span>Gratis</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3"">
                                <div>
                                    <strong>The total amount of</strong>
                                    <strong>
                                        <p class=""mb-0"">(including VAT)</p>
                                    </strong>
                                </div>
                                <span><strong>$ ");
#nullable restore
#line 156 "C:\Users\haris\Source\Repos\ImageCRUD\Views\Cart\Index.cshtml"
                                            Write(@vat*@sum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></span>
                            </li>
                        </ul>

                        <input type=""submit"" class=""btn btn-primary btn-block"" value=""Go to checkout"" />



                    </div>
                </div>
                <!-- Card -->
                <!-- Card -->
                <div class=""mb-3"">
                    <div class=""pt-4"">

                        <a class=""dark-grey-text d-flex justify-content-between"" data-toggle=""collapse"" href=""#collapseExample""
                           aria-expanded=""false"" aria-controls=""collapseExample"">
                            Add a discount code (optional)
                            <span><i class=""fas fa-chevron-down pt-1""></i></span>
                        </a>

                        <div class=""collapse"" id=""collapseExample"">
                            <div class=""mt-3"">
                                <div class=""md-form md-outline mb-0"">
                                    <input type=""text"" id=""");
                WriteLiteral(@"discount-code"" class=""form-control font-weight-light""
                                           placeholder=""Enter discount code"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Card -->

            </div>
            <!--Grid column-->

        </div>
        <!-- Grid row -->

    </section>
    <!--Section: Block Content-->


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImageCRUD.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
