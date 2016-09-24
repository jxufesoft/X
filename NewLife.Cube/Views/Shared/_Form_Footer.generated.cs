﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_Form_Footer.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 2 "..\..\Views\Shared\_Form_Footer.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Footer.cshtml")]
    public partial class _Views_Shared__Form_Footer_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Footer_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Form_Footer.cshtml"
  
    var entity = Model as IEntity;
    var fact = EntityFactory.CreateOperate(entity.GetType());
    var fields = ViewBag.Fields as List<FieldItem>;

    var cid = fact.Table.FindByName("CreateUserID") as FieldItem;
    var uid = fact.Table.FindByName("UpdateUserID") as FieldItem;
    var cip = fact.Table.FindByName("CreateIP") as FieldItem;
    var uip = fact.Table.FindByName("UpdateIP") as FieldItem;
    var remark = fact.Table.FindByName("Remark") as FieldItem;
    if (remark == null) { remark = fact.Table.FindByName("Description"); }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Shared\_Form_Footer.cshtml"
 if (cid != null)
{
    var user = fact.Table.FindByName("CreateUserName") as FieldItem;
    var time = fact.Table.FindByName("CreateTime") as FieldItem;

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group col-sm-12 col-md-6\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-2 col-md-2\"");

WriteLiteral(">创建</label>\r\n        <div");

WriteLiteral(" class=\"control-label col-xs-8 col-sm-8 col-md-10\"");

WriteLiteral(" style=\"text-align: left;\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Views\Shared\_Form_Footer.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (user != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Shared\_Form_Footer.cshtml"
                                      Write(entity[user.Name]);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 25 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 26 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (time != null)
                {
                    var dt = (DateTime)entity[time.Name];

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Shared\_Form_Footer.cshtml"
                                      Write(dt.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 30 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 31 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (cip != null)
                {
                    var ip = entity[cip.Name] + "";

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1462), Tuple.Create("\"", 1473)
            
            #line 34 "..\..\Views\Shared\_Form_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 1470), Tuple.Create<System.Object, System.Int32>(ip
            
            #line default
            #line hidden
, 1470), false)
);

WriteLiteral(">");

            
            #line 34 "..\..\Views\Shared\_Form_Footer.cshtml"
                                                  Write(ip.IPToAddress());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 35 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

            
            #line 38 "..\..\Views\Shared\_Form_Footer.cshtml"
}

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Shared\_Form_Footer.cshtml"
 if (uid != null)
{
    var user = fact.Table.FindByName("UpdateUserName") as FieldItem;
    var time = fact.Table.FindByName("UpdateTime") as FieldItem;

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group col-sm-12 col-md-6\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-2 col-md-2\"");

WriteLiteral(">更新</label>\r\n        <div");

WriteLiteral(" class=\"control-label col-xs-8 col-sm-8 col-md-10\"");

WriteLiteral(" style=\"text-align: left;\"");

WriteLiteral(">\r\n");

            
            #line 46 "..\..\Views\Shared\_Form_Footer.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (user != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Shared\_Form_Footer.cshtml"
                                      Write(entity[user.Name]);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 49 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 50 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (time != null)
                {
                    var dt = (DateTime)entity[time.Name];

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Shared\_Form_Footer.cshtml"
                                      Write(dt.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 54 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 55 "..\..\Views\Shared\_Form_Footer.cshtml"
             if (uip != null)
                {
                    var ip = entity[uip.Name] + "";

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-primary\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2397), Tuple.Create("\"", 2408)
            
            #line 58 "..\..\Views\Shared\_Form_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 2405), Tuple.Create<System.Object, System.Int32>(ip
            
            #line default
            #line hidden
, 2405), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Views\Shared\_Form_Footer.cshtml"
                                                  Write(ip.IPToAddress());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 59 "..\..\Views\Shared\_Form_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

            
            #line 62 "..\..\Views\Shared\_Form_Footer.cshtml"
}

            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Shared\_Form_Footer.cshtml"
 if (remark != null && !fields.Contains(remark))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group col-sm-12 col-md-12\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-2 col-md-1\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Shared\_Form_Footer.cshtml"
                                                           Write(remark.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        <div");

WriteLiteral(" class=\"col-xs-8 col-sm-8 col-md-8\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 68 "..\..\Views\Shared\_Form_Footer.cshtml"
       Write(Html.ForString(remark.Name, (String)entity[remark.Name], -1));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 69 "..\..\Views\Shared\_Form_Footer.cshtml"
       Write(Html.ForDescription(remark));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 72 "..\..\Views\Shared\_Form_Footer.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
