#pragma checksum "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85020770baff6c9aeec4e0a0e3a4095c58eceb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Role_RoleIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Role/RoleIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85020770baff6c9aeec4e0a0e3a4095c58eceb14", @"/Areas/SystemManage/Views/Role/RoleIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Role_RoleIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        角色名称：<input id=""roleName"" col=""RoleName"" type=""text"" />
                    </li>
                    <li>
                        角色状态：<span id=""roleStatus"" col=""RoleStatus""></span>
                    </li>
                    <li class=""select-time"">
                        <label>创建时间： </label>
                        <input id=""startTime"" col=""StartTime"" type=""text"" class=""time-input"" placeholder=""开始时间"" />
                        <span>-</span>
                        <input id=""endTime"" col=""EndTime"" type=""text"" class=""time-input"" placeholder=""结束时间"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
    ");
            WriteLiteral(@"            </ul>
            </div>
        </div>
        <div class=""btn-group-sm"" id=""toolbar"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
        </div>

        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();

        $(""#roleStatus"").ysComboBox({ data: ys.getJson(");
#nullable restore
#line 43 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n\r\n        laydate.render({ elem: \'#startTime\', format: \'yyyy-MM-dd\' });\r\n        laydate.render({ elem: \'#endTime\', format: \'yyyy-MM-dd\' });\r\n    });\r\n\r\n    function initGrid() {\r\n        var queryUrl = \'");
#nullable restore
#line 50 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                   Write(Url.Content("~/SystemManage/Role/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            sortName: 'RoleSort',
            sortOrder: 'Asc',
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'RoleName', title: '角色名称', width: ""15%"",sortable: true },
                { field: 'RoleSort', title: '显示顺序', width: ""15%"",sortable: true },
                {
                    field: 'RoleStatus', title: '状态', width: ""15%"",
                    formatter: function (value, row, index) {
                        if (value == """);
#nullable restore
#line 63 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                                 Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
#nullable restore
#line 64 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                                                                      Write(StatusEnum.Yes.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
#nullable restore
#line 66 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                                                                      Write(StatusEnum.No.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + '</span>';
                        }
                    }
                },
                {
                    field: 'BaseModifyTime', title: '创建时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $(""#searchDiv"").getWebControls(pagination);
                return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                i");
            WriteLiteral("d = selectedRow[0].Id;\r\n            }\r\n        }\r\n        ys.openDialog({\r\n            title: id > 0 ? \"编辑角色\" : \"添加角色\",\r\n            content: \'");
#nullable restore
#line 102 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                 Write(Url.Content("~/SystemManage/Role/RoleForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            width: ""780px"",
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
#line 117 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\Role\RoleIndex.cshtml"
                     Write(Url.Content("~/SystemManage/Role/DeleteFormJson"));

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