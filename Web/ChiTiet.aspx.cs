using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class xemdiem : System.Web.UI.Page
{
    ketnoi_csdl ketnoi = new ketnoi_csdl();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["nam"] == null)
        //{
        //    // ko có session năm thì ko hiện gì cả
        //}
        //else
        //{
            //string sql = "select * from view_tongdiem where sobd='" + Request.QueryString["sobd"].ToString() + "' and namthi='" + Session["nam"].ToString() + "'";
            string sql = "select * from view_tongdiem where sobd='" + Request.QueryString["sobd"].ToString() + "' and namthi='" + Request.QueryString["namthi"].ToString() + "'";
            GridView1.DataSource = ketnoi.taobang(sql);
            GridView1.DataBind();
        //}

    }
}
