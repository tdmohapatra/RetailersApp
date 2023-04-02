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
    public partial class ProductRegistrationPage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            string Item_code = tbItemCode.Text;
            string Item_Name = tbItemName.Text;
            SqlConnection connection = new SqlConnection(cn);
            String qry = $"Insert into ITEM_TABLE values('{Item_code}','{Item_Name}')";
            SqlCommand command = new SqlCommand(qry, connection);
            connection.Open();
            int InsertedRows = command.ExecuteNonQuery();
            if (InsertedRows > 0)
            {
                Response.Output.Write("Inserted Sucessfullly");
                // Response.Redirect("ItemRegisterPage,aspx");
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}