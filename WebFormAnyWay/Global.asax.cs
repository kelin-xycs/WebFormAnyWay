using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.Web.Routing;

namespace WebFormAnyWay
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //  配置路由
            //  配置了 如下 路由 后，可通过 Url 如  http://localhost/WebForm1  访问  WebForm1.aspx
            //  但 仍然 可以 通过 Url  http://localhost:14739/WebForm1.aspx  访问  WebForm1.aspx
            //  有关 Asp.net 路由，可参阅 MSDN ： https://msdn.microsoft.com/zh-cn/library/cc668201(v=vs.100).aspx

            //  配置路由 不是 必需 的，只有 业务 需要的时候，再这么做。

            //  简洁高效 的 构建系统，是 第一目标。

            RouteTable.Routes.MapPageRoute("", "{WebForm}", "~/{WebForm}.aspx");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();

            ex = ex.InnerException != null ? ex.InnerException : ex;

            //    log.Error( ex.ToString() );
            Response.Write("Error：" + ex.ToString());
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}