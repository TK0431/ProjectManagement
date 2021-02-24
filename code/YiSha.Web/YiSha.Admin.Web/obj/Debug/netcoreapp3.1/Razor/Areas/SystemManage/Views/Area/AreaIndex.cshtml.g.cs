#pragma checksum "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb7b870096c6ed5b91668281212898f6ed6b23e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Area_AreaIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Area/AreaIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 2 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb7b870096c6ed5b91668281212898f6ed6b23e", @"/Areas/SystemManage/Views/Area/AreaIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Area_AreaIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        地点名称：<input id=""areaName"" col=""AreaName"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchTreeGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm"" id=""toolbar"">
            <a id=""btnDelete"" class=""btn btn-danger"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
        </div>

        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">

    $(function () {

        initTreeGrid();

    });

    funct");
            WriteLiteral(@"ion initTreeGrid() {
        var options = {
            code: ""AreaCode"",
            parentCode: ""ParentAreaCode"",
            uniqueId: ""Id"",
            expandAll: false,
            expandFirst: false,
            toolbar: '#toolbar',
            expandColumn: '2',
            url: '");
#nullable restore
#line 52 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
             Write(Url.Content("~/SystemManage/Area/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            modalName: ""行政区划"",
            columns: [
                { field: 'Id', visible: false },
                { field: 'selectItem', radio: true },
                { field: 'AreaName', title: '地点名称', width: '50%' },
                { field: 'ZipCode', title: '邮政编码', width: '25%', align: ""left"" },
                { field: 'AreaLevel', title: '级别', width: '25%', align: ""left"" }
            ]
        };
        $('#gridTable').ysTreeTable(options);
    }

    function searchTreeGrid() {
        var param = $(""#searchDiv"").getWebControls();
        $('#gridTable').ysTreeTable('search', param);
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id = selectedRow[0].Id;
            }
        }
        ys.openDialog({
            title: id > 0 ? ""编");
            WriteLiteral("辑\" : \"添加\",\r\n            content: \'");
#nullable restore
#line 83 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
                 Write(Url.Content("~/SystemManage/Area/AreaForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 97 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Area\AreaIndex.cshtml"
                     Write(Url.Content("~/SystemManage/Area/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
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
