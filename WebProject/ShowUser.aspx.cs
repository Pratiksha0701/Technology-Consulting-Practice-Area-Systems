using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebProject
{
    public partial class ShowUser : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
            }


        }
        protected void display()
        {
            try
            {
                string email = Session["email"].ToString();
                string location = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\manadementdb_Rohitd.mdf;Integrated Security=True";
                con = new SqlConnection(location);
                con.Open();

                string que = "select * from registerdb where email=@email1";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("email1", email);
                dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }
    }
}