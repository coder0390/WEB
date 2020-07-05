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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblCount.Text = "您是第" + Application["count"].ToString() + "位访客";//网站人数统计

        int P_int_judge = 0;
        P_int_judge = Convert.ToInt32(Request["value"]); //value的值就是P_int_judge的值
        if (!IsPostBack) //IsPostBack 获取一个值，该值指示页是第一次呈现还是为了响应回发而加载
        {
            if (P_int_judge == 1)
                Response.Write("<script>alert('该用户已经登录！')</script>");
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Application.Lock();
        int P_int_num;     //在线人数
        string P_str_name; //登录用户
        string P_str_names; 　//已在线的用户名
        string[] P_str_user;　//用户在线数组
        P_int_num = int.Parse(Application["userNum"].ToString());
        if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('用户名不能为空')</script>");
            TextBox1.Focus();
        }
        else
        {
            P_str_name = TextBox1.Text.Trim();
            P_str_names = Application["user"].ToString();
            P_str_user = P_str_names.Split(',');
            for (int i = 0; i <= P_int_num - 1; i++)
            {
                if (P_str_name == P_str_user[i].Trim())
                {
                    int P_int_judge = 1;
                    Response.Redirect("Login.aspx?value=" + P_int_judge);                
                }
            }
            if (P_int_num == 0)
                Application["user"] = P_str_name.ToString();
            else
                Application["user"] = Application["user"] + "," + P_str_name.ToString();
            P_int_num += 1;
            Application["userNum"] = P_int_num;
            Session["userName"] = TextBox1.Text.Trim();
            Application.UnLock();
            Response.Redirect("Chat.aspx");
        }
    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(),"", "<script>window.opener=null;window.open('','_self');window.close();closeCurrentWindow</script>",true);
    }
}