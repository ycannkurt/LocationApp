#pragma checksum "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Build\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6db5a74d0a9710c2943ab9514f132688c463669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Build_List), @"mvc.1.0.view", @"/Views/Build/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Build/List.cshtml", typeof(AspNetCore.Views_Build_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6db5a74d0a9710c2943ab9514f132688c463669", @"/Views/Build/List.cshtml")]
    public class Views_Build_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Build\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(105, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(112, 71, false);
#line 7 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Build\List.cshtml"
Write(Html.RenderPartialAsync("~/Views/Shared/Partials/DataTable/_Css.cshtm"));

#line default
#line hidden
                EndContext();
                BeginContext(183, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(188, 5827, true);
            WriteLiteral(@"<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h3>Lokasyon <small> Blok</small></h3>
            </div>
            <div class=""title_right pull-right"">
                <div class=""col-md-12 col-sm-12 col-xs-12 col-lg-12 form-group pull-right"">
                    <div class=""input-group pull-right"">
                        <button type=""button"" data-toggle=""modal"" data-target=""#exampleModal"" class=""btn btn-success pull-right ""><i class=""fa fa-plus-circle""></i> Yeni</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Bloklar<small></small></h2>
                        <div class=""clearfix""></div>
             ");
            WriteLiteral(@"       </div>
                    <div class=""x_content"">
                        <p class=""text-muted font-13 m-b-30"">
                        </p>
                        <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Bina</th>
                                    <th>Blok</th>
                                    <th>GPS</th>
                                    <th>İşlemler</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Bina Adı</td>
                                    <td>Blok Adı</td>
                                    <td>Gps Bilgileri</td>
                                    <td>
                                        <button type=""button"" class=""btn ");
            WriteLiteral(@"btn-round btn-danger""><i class=""fa fa-edit fa-hover""></i><span class=""text-muted""></span></button>
                                        <button type=""button"" class=""btn btn-round btn-info""><i class=""fa fa-trash fa-hover""></i><span class=""text-muted""></span></button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /page content -->
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <sp");
            WriteLiteral(@"an aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <form id=""demo-form2"" data-parsley-validate class=""form-horizontal form-label-left"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""first-name"">
                            Blok Adı : <span class=""required"">*</span>
                        </label>
                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <input type=""text"" id=""first-name"" required=""required"" class=""form-control col-md-7 col-xs-12"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""last-name"">
                            Gps <span class=""required"">*</span>
                        </label>
                        <div class=""col-md-6 col-sm");
            WriteLiteral(@"-6 col-xs-12"">
                            <input type=""text"" id=""last-name"" name=""last-name"" required=""required"" class=""form-control col-md-7 col-xs-12"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Bina</label>
                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <select class=""form-control"">
                                <option>Choose option</option>
                                <option>Option one</option>
                                <option>Option two</option>
                                <option>Option three</option>
                                <option>Option four</option>
                            </select>
                        </div>
                    </div>
                    <div class=""ln_solid""></div>
                    <div class=""form-group"">
                        <div class");
            WriteLiteral(@"=""col-md-6 col-sm-6 col-xs-12 col-md-offset-3"">
                            <button class=""btn btn-primary"" type=""button"">Cancel</button>
                            <button class=""btn btn-primary"" type=""reset"">Reset</button>
                            <button type=""submit"" class=""btn btn-success"">Submit</button>
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6032, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6039, 71, false);
#line 121 "E:\Developers\Repository\LocationApp\LocationApp.Web\Views\Build\List.cshtml"
Write(Html.RenderPartialAsync("~/Views/Shared/Partials/DataTable/_Js.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(6110, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591