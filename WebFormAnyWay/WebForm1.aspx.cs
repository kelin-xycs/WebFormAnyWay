using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace WebFormAnyWay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //  异常 在 Global.asax 的 Application_Error() 方法中 统一处理
        //  配置路由 在 Global.asax 的 Application_Start() 方法中
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable dt = BL.FetchPerson();

            gridView.DataSource = dt;
            gridView.DataBind();


            GridView grid = personGrid.GridView;

            grid.DataSource = dt;
            grid.DataBind();
            
        }
        
    }
}