using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;

namespace WebFormAnyWay
{
    public class Html
    {
        public static string Render(Control ctrl)
        {
            using (System.IO.TextWriter tw = new System.IO.StringWriter())
            {
                using(HtmlTextWriter writer = new HtmlTextWriter(tw))
                {
                    ctrl.RenderControl(writer);  
                }

                return tw.ToString(); 
            }
            
        }
    }
}