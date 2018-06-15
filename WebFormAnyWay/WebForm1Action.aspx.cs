using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace WebFormAnyWay
{
    public partial class WebForm1Action : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result;
            string action = Request["action"];
            
            switch (action)
            {
                case "Query":
                    result = Query();
                    break;
                case "Update":
                    result = Update();
                    break;
                default:
                    throw new Exception("没有这个 action：\"" + action + "\"。");

            }

            Response.Write(result);

        }

        //  覆写 这个 方法 是因为，如果不覆写的话，在 Render 控件 的 时候，这个方法 会 要求 控件必须 放在 runat="server" 的 form 内
        //  不然，会 抛出异常
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        private string Query()
        {
            //  加这一句 Thread.Sleep()  是 为了在 浏览器 里 明显的 看到 loading 效果
            System.Threading.Thread.Sleep(3000);

            return BindGrid();
        }

        private string Update()
        {
            //  加这一句 Thread.Sleep()  是 为了在 浏览器 里 明显的 看到 loading 效果
            System.Threading.Thread.Sleep(3000);

            BL.UpdatePerson();

            return BindGrid();
        }

        private string BindGrid()
        {
            PersonGrid uc = (PersonGrid)LoadControl("PersonGrid.ascx");

            GridView grid = uc.GridView;

            DataTable dt = BL.FetchPerson();

            grid.DataSource = dt;
            grid.DataBind();

            return Html.Render(grid);
        }
    }
}