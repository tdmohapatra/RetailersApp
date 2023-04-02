using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RetailersApp
{
    public partial class UserRegistrationPage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cn))
            {
                string name = tbNmae.Text;
                String Email = tbEmail.Text;
                String Phn = tbPhn.Text;
                string Pwd = tbPwd.Text;

                String Qry = $"insert into REGISTRATION_TABLE(USER_NAME,EMAIL,PHN_NO,PASSWORD) values ('{name}','{Email}','{Phn}','{Pwd}')";
                using (SqlCommand cmd = new SqlCommand(Qry, con))
                {
                    try
                    {
                        con.Open();
                        int InsertedRows = cmd.ExecuteNonQuery();
                        if (InsertedRows > 0)
                        {
                            Response.Output.Write($"{name} Redgistation SucessFully");

                        }

                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}