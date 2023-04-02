using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RetailersApp
{
    public partial class UserLoginPage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cn))
            {
                String U_Name = tbNmae.Text;
                String U_pwd = tbPwd.Text;
                String Qry = "select USER_NAME,PASSWORD from REGISTRATION_TABLE";
                using (SqlCommand command = new SqlCommand(Qry, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        bool x = true;
                        while (dr.Read())
                        {
                            if (U_Name == dr["USER_NAME"].ToString() && U_pwd == dr["PASSWORD"].ToString())
                            {
                                Response.Redirect("HomePage.aspx");
                            }
                            else
                            {
                                x = false;
                            }
                        }
                        if (x == false)
                        {
                            Response.Output.Write("Login Unsucessfull <br/> please try again");
                        }
                        dr.Close();
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }

                    }
                }

            }

        }
    }
}