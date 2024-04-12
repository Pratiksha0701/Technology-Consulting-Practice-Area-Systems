using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtlogin.Text != "" || txtpass.Text != "")
                {

                    string location = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\manadementdb_Rohitd.mdf;Integrated Security=True";
                    con = new SqlConnection(location);
                    con.Open();

                    string que = "select * from registerdb where email=@email1 and password=@pass1";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("email1", txtlogin.Text);
                    cmd.Parameters.AddWithValue("pass1", txtpass.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Session["fname"] = dr["fname"].ToString();
                        Session["email"] = dr["email"].ToString();
                        Response.Redirect("Dashboard.aspx");

                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Invalid User ','Please Register First','error')", true);
                    }

                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Sorry ','Please fill all data carefully','error')", true);

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            
            

        }
    }
}