#pragma checksum "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f012344712c9c86d8273fa1fe73bc5e422dddde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_News_NewsForm), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
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
#line 3 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f012344712c9c86d8273fa1fe73bc5e422dddde", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_News_NewsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 161, "\"", 226, 1);
#nullable restore
#line 6 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 168, Url.Content("~/lib/summernote/0.8.15/summernote.min.css"), 168, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 274, "\'", 333, 1);
#nullable restore
#line 7 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 280, Url.Content("~/lib/summernote/0.8.15/summernote.js"), 280, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 380, "\'", 454, 1);
#nullable restore
#line 8 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
WriteAttributeValue("", 386, Url.Content("~/lib/summernote/0.8.15/lang/summernote-zh-CN.min.js"), 386, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n    ");
#nullable restore
#line 10 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/css/imgup.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/js/imgup.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f012344712c9c86d8273fa1fe73bc5e422dddde8272", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">标题 <font class=""red""> *</font> </label>
            <div class=""col-sm-10"">
                <input id=""newsTitle"" col=""NewsTitle"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章类别<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""newsType"" col=""NewsType""></div>
            </div>
            <label class=""col-sm-2 control-label "">发布时间<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsDate"" col=""NewsDate"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">作者<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsAuthor"" col=""NewsAuthor"" type=""text"" class=""form");
                WriteLiteral(@"-control"" />
            </div>
            <label class=""col-sm-2 control-label "">排序<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsSort"" col=""NewsSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        ");
#nullable restore
#line 45 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
   Write(await Html.PartialAsync("/Areas/SystemManage/Shared/AreaFormPartial.cshtml", new ViewDataDictionary(this.ViewData) { { "Label", "2" }, { "Content", "10" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章标签</label>
            <div class=""col-sm-10"">
                <input id=""newsTag"" col=""NewsTag"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">
                <span>缩略图</span><br />
                <span>(宽高比 1.5：1)</span>
            </label>
            <div class=""col-sm-10"">
                <div id=""thumbImage"" class=""img-box"">
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章内容 </label>
            <div class=""col-sm-10"">
                <div id=""newsContent"" class=""summernote""></div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

<script type=""text/javascript"">
    var id = ys.request(""id"");
    $(function () {
        laydate.render({ elem: '#newsDate', type: 'datetime', format: 'yyyy-MM-dd HH:mm' });

        $('#newsTag').tagsinput({ trimValue: true });

        $(""#newsType"").ysComboBox({
            data: top.getDataDict(""NewsType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });

        $('#newsContent').summernote({
            height: '220px',
            lang: 'zh-CN',
            dialogsInBody: true,
            callbacks: {
                onImageUpload: function (files, editor, welEditable) {
                    uploadNewsImage(files[0], editor, welEditable);
                }
            }
        });

        $(""#thumbImage"").imageUpload({ uploadImage: 'uploadThumbImage', limit: 1, context: ctx });

        getForm();

        $(""#form"").validate({
            rules: {
                newsTitle: { required: true },
   ");
            WriteLiteral(@"             newsType_select: { required: true },
                newsDate: { required: true },
                newsAuthor: { required: true },
                newsSort: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 114 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        obj.Data.NewsDate = ys.formatDate(obj.Data.NewsDate, ""yyyy-MM-dd HH:mm"");
                        $(""#form"").setWebControls(obj.Data);
                        $(""#newsContent"").summernote('code', obj.Data.NewsContent);
                        $(""#thumbImage"").imageUpload(""setImageUrl"", obj.Data.ThumbImage);

                        $.each(obj.Data.NewsTag.split(','), function (index,val) {
                             $('#newsTag').tagsinput('add', val);
                        });
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
#nullable restore
#line 132 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetMaxSortJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"get\",\r\n                success: function (obj) {\r\n                    if (obj.Tag == 1) {\r\n                        var defaultData = {};\r\n                        defaultData.NewsAuthor = \"");
#nullable restore
#line 137 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                             Write(ViewBag.OperatorInfo.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                        defaultData.NewsDate = \'");
#nullable restore
#line 138 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                           Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                        defaultData.NewsSort = obj.Data;
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            postData.NewsContent = $(""#newsContent"").summernote('code');
            postData.ThumbImage = $(""#thumbImage"").imageUpload(""getImageUrl"");
            ys.ajax({
                url: '");
#nullable restore
#line 153 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }

    function uploadNewsImage(file, editor, welEditable) {
        var formdata = new FormData();
        formdata.append(""fileList"", file);
        ys.ajaxUploadFile({
            url: '");
#nullable restore
#line 174 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 174 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: formdata,\r\n            success: function (obj) {\r\n                if (obj.Tag == 1) {\r\n                    $(\"#newsContent\").summernote(\'insertImage\', \'");
#nullable restore
#line 178 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                            Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + obj.Data, '/');
                }
                else {
                    ys.msgError(obj.Message);
                }
            }
        })
    }

    function uploadThumbImage(file, callback) {
        var formdata = new FormData();
        formdata.append(""fileList"", file);
        ys.ajaxUploadFile({
            url: '");
#nullable restore
#line 191 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
#nullable restore
#line 191 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: formdata,\r\n            success: function (obj) {\r\n                if (obj.Tag == 1) {\r\n                    if (callback) {\r\n                        callback(\'");
#nullable restore
#line 196 "E:\快速开发框架源码\code\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + obj.Data);\r\n                    }\r\n                }\r\n                else {\r\n                    ys.msgError(obj.Message);\r\n                }\r\n            }\r\n        })\r\n    }\r\n</script>\r\n\r\n");
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
