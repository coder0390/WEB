using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        txtContent.Text = "";
        int P_int_current = Convert.ToInt32(Application["current"]); //current当前聊天记录的总数
        ArrayList ItemList = new ArrayList();
        Application.Lock();
        string P_str_names;       //已在线的用户名
        string[] P_str_user;        //用户在线数组
        int P_int_num = Convert.ToInt32(Application["userNum"]);
        P_str_names = Application["user"].ToString();//用户名, 其实是一个以 ,  分割的字符串的组织形式
        P_str_user = P_str_names.Split(',');
        for (int i = (P_int_num - 1); i >= 0; i--)
        {
            if (P_str_user[i].ToString() != "")
                ItemList.Add(P_str_user[i].ToString());
        }
        lbList.DataSource = ItemList;
        lbList.DataBind(); //绑定用户名
        string P_str_chats = Application["chats"].ToString();
        string[] P_str_chat = P_str_chats.Split(',');
        //往文本框中写入聊天记录
        for (int i = P_str_chat.Length - 1; i >= 0; i--)
        {
            if (P_int_current == 0)
            {
                txtContent.Text = P_str_chat[i].ToString();
            }
            else
            {
                txtContent.Text = txtContent.Text + "\n" + P_str_chat[i].ToString();
            }
        }
        Application.UnLock();
        UpdatePanel1.Update(); //UpdatePanel用来实现局部更新
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (Session["userName"] == null || Session["userName"].ToString().Length<=0)
        {
            return;
        }
        int P_int_current = Convert.ToInt32(Application["current"]);
        Application.Lock();
        if (P_int_current == 0 || P_int_current > 20)
        {
            P_int_current = 0;
            Application["chats"] = Session["userName"].ToString() + "说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
        }
        else
        {
            Application["chats"] = Application["chats"].ToString() + "," + Session["userName"].ToString() + "说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
        }
        P_int_current += 1;
        Application["current"] = P_int_current;
        Application.UnLock();
        UpdatePanel2.Update();//更新局部面板
    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Application.Lock();
        string P_str_userName = Application["user"].ToString();
        Application["user"] = P_str_userName.Replace(Session["userName"].ToString(), "");
        Session["userName"] = ""; //清空session
        string astr = Application["user"].ToString();
        Application.UnLock();
        Response.Redirect("Login.aspx");//退出后转到登录界面
    }
}