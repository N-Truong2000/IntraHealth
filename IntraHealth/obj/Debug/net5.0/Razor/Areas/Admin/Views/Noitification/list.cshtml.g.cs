#pragma checksum "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d00fd416ca2f787a372c1b449510e22960538fde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Noitification_list), @"mvc.1.0.view", @"/Areas/Admin/Views/Noitification/list.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00fd416ca2f787a372c1b449510e22960538fde", @"/Areas/Admin/Views/Noitification/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Noitification_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "noitification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
  
    ViewData["Title"] = "list";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"page-wrapper\">\r\n    <div class=\"header\">\r\n        <h1 class=\"page-header\">\r\n            notification Intralhealth <small></small>\r\n        </h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d00fd416ca2f787a372c1b449510e22960538fde5310", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d00fd416ca2f787a372c1b449510e22960538fde6890", async() => {
                WriteLiteral("Notification");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>

        </ol>
    </div>
    <div id=""page-inner"">
        <!--List table-->
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- Advanced Tables -->
                <div class=""panel panel-warning "" style=""box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;"">
                    <div class=""panel-heading"">
                        <h2>Send mess</h2>  
                    </div>
                    <div class=""panel-body"">
                        <div class=""table-responsive "">
                            <table class=""table table-striped table-bordered table-hover "" id=""dataTables-example"">
                                <thead>
                                    <tr>
                                        <th>id</th>
                                        <th>form</th>
                                        <th>idUser</th>
                                        <th>TextNotification </th>
                                        <th>time Create</th>
 ");
            WriteLiteral(@"                                       <th>SendTimeNotification </th>
                                        <th>Status</th>                                      
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 42 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                     if (ViewBag.ev != null)
                                    {
                                        foreach (var ev in ViewBag.ev)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\"odd gradeX\">\r\n                                                <td>");
#nullable restore
#line 47 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.IdNotification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.FromAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 49 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 50 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.TextNotification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 51 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.SendTimeNotification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 52 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                               Write(ev.StatusNotification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                                 if (ev.StatusNotification == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td class=\"text-success\">active</td>\r\n");
#nullable restore
#line 56 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                                }
                                                else if (ev.StatusNotification == null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td class=\"text-success\">inactive</td>\r\n");
#nullable restore
#line 60 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td class=\"text-success\">inactive</td>\r\n");
#nullable restore
#line 64 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                                }                                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 66 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                        }

                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                   Write(ViewBag.err);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Study(2019-2020)\HK3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Noitification\list.cshtml"
                                                    
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!--End Advanced Tables -->
            </div>
        </div>
        <footer><p>All right reserved. Template by: <a href=""http://webthemez.com"">WebThemez.com</a></p></footer>
    </div>
    <!-- /. PAGE INNER  -->
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
