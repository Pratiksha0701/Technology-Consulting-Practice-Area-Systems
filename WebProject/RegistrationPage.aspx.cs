using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebProject
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text=="" || txtlname.Text=="" || txtemail.Text==""||txtpassword.Text==""||txtcpassword.Text==""||txtcontact.Text=="" )
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Sorry ','Please fill all data carefully','error')", true);
            }
            else
            {
                try
                {
                    var p1 = txtpassword.Text;
                    var p2 = txtcpassword.Text;
                    if (p1 == p2)
                    {

                        string location = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\manadementdb_Rohitd.mdf;Integrated Security=True";
                        con = new SqlConnection(location);
                        con.Open();

                        string que = "select * from registerdb where email=@email1";
                        cmd = new SqlCommand(que, con);
                        cmd.Parameters.AddWithValue("email1", txtemail.Text);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Invalid User','user not found','error')", true);
                        }
                        else
                        {
                            string time = DateTime.Now.ToString("yyyy-MM-dd");
                            string location1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\manadementdb_Rohitd.mdf;Integrated Security=True";
                            con = new SqlConnection(location1);
                            con.Open();

                            string querry = "insert into registerdb (fname,lname,email,contact,password,date) values(@fname1,@lname1,@email1,@contact1,@password1,@date1)";
                            cmd = new SqlCommand(querry, con);
                            cmd.Parameters.AddWithValue("fname1", txtfname.Text);
                            cmd.Parameters.AddWithValue("lname1", txtlname.Text);
                            cmd.Parameters.AddWithValue("email1", txtemail.Text);
                            cmd.Parameters.AddWithValue("contact1", txtcontact.Text);
                            cmd.Parameters.AddWithValue("password1", txtpassword.Text);
                            cmd.Parameters.AddWithValue("date1", time);
                            cmd.ExecuteNonQuery();
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "j", "swal('Congratulations','Registration successfull','success')", true);
                            dr.Close();
                            txtfname.Text = "";
                            txtlname.Text = "";
                            txtemail.Text = "";
                            txtpassword.Text = "";
                            txtcpassword.Text = "";
                        }
                        con.Close();


                    }
                    else
                    {
                        lblmessage.Text = "Password doesent Match";
                    }


                }
                catch(Exception ex)
                {
                    Response.Write(ex);
                }
                


            }
        }

    }
}