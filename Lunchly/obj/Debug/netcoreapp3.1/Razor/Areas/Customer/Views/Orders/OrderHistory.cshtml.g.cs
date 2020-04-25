#pragma checksum "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bfcb8a4c5dee5820d252cfac04cb67d845ffe80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Orders_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Orders/OrderHistory.cshtml")]
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
#line 1 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\_ViewImports.cshtml"
using Lunchly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\_ViewImports.cshtml"
using Lunchly.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
using Lunchly.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfcb8a4c5dee5820d252cfac04cb67d845ffe80", @"/Areas/Customer/Views/Orders/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc4098f381af0da2294a7fc15c70e1db03a9987", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Orders_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lunchly.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"border background-white\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\"> Past Order List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bfcb8a4c5dee5820d252cfac04cb67d845ffe804249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 21 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
         if (Model.Orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.TotalOrderPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Total Items\r\n                    </th>\r\n                    <th></th>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.TotalOrderPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 68 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                                                                                           Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                <i class=\"far fa-list-alt\"></i> Details\r\n                            </button>\r\n");
#nullable restore
#line 71 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                             if (item.OrderHeader.Status == SD.StatusSubmitted || item.OrderHeader.Status == SD.StatusInProcess || item.OrderHeader.Status == SD.StatusCompleted || item.OrderHeader.Status == SD.StatusReady)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-info btnOrderStatus\" data-id=\"");
#nullable restore
#line 73 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                                                                                              Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                    <i class=\"far fa-clock\"></i> Status\r\n                                </button>\r\n");
#nullable restore
#line 76 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
            WriteLiteral("            <div");
            BeginWriteAttribute("page-model", " page-model=\"", 3390, "\"", 3420, 1);
#nullable restore
#line 82 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
WriteAttributeValue("", 3403, Model.PagingInfo, 3403, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-classes-enabled=\"true\" page-class=\"btn border\"\r\n                 page-class-normal=\"btn btn-light\" page-class-selected=\"btn btn-info active\"\r\n                 class=\"btn-group float-right\">\r\n            </div>\r\n");
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 88 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No category exists...</p>\r\n");
#nullable restore
#line 92 "C:\Users\mr_ho\source\repos\Lunchly\Lunchly\Areas\Customer\Views\Orders\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-centered modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">Order Details</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModalContent"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""myOrderStatus"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info text-light justify-content-center"">
                <h5 class=""modal-title"">Order");
            WriteLiteral(@" Status </h5>
            </div>
            <div class=""modal-body justify-content-center"" id='myOrderStatusContent'>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var PostBackURL = '/Customer/Orders/GetOrderDetails';
        var OrderStatusURL = '/Customer/Orders/GetOrderStatus';
        $(function () {
            $("".anchorDetail"").click(function () {
                var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: PostBackURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed"");
                    }
                });
            });
            $("".btnOrderStatus"").click(function () {
           ");
                WriteLiteral(@"     var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');
                $.ajax({
                    type: ""GET"",
                    url: OrderStatusURL,
                    contentType: ""text/html; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    dataType: ""html"",
                    success: function (data) {
                        $('#myOrderStatusContent').html(data);
                        $('#myOrderStatus').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed."");
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lunchly.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
