using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebProject
{

    public partial class ManageUser : System.Web.UI.Page
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
                if (dr.Read())
                {
                    txtfname.Text = dr["fname"].ToString();
                    txtlname.Text = dr["lname"].ToString();
                    txtemail.Text = dr["email"].ToString();
                    txtcontact.Text = dr["contact"].ToString();
                    txtdate.Text = dr["date"].ToString();
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
 


        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Session["email"].ToString();
                string location = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\manadementdb_Rohitd.mdf;Integrated Security=True";
                con = new SqlConnection(location);
                con.Open();

                string que = "update  registerdb set fname=@fname1,lname=@lname1,contact=@contact1,date=@date1,address=@address1 where email=@email1";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("email1", email);
                cmd.Parameters.AddWithValue("fname1", txtfname.Text);
                cmd.Parameters.AddWithValue("lname1", txtlname.Text);
                cmd.Parameters.AddWithValue("contact1", txtcontact.Text);
                cmd.Parameters.AddWithValue("date1", txtdate.Text);
                cmd.Parameters.AddWithValue("address1", txtaddress.Text);
                cmd.ExecuteNonQuery();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Updated ','Record updated successfully','success')", true);


            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            

        }
    }
}