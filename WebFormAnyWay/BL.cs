using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

namespace WebFormAnyWay
{
    public class BL
    {
        public static DataTable FetchPerson()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("age");
            dt.Columns.Add("timestamp");

            DataRow dr = dt.NewRow();
            dr["id"] = "001";
            dr["name"] = "小刚";
            dr["age"] = 10;
            dr["timestamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "002";
            dr["name"] = "小明";
            dr["age"] = 20;
            dr["timestamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "003";
            dr["name"] = "小红";
            dr["age"] = 30;
            dr["timestamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "004";
            dr["name"] = "小花";
            dr["age"] = 40;
            dr["timestamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dt.Rows.Add(dr);

            return dt;
        }

        public static void UpdatePerson()
        {
            //  Update Person
        }
    }
}