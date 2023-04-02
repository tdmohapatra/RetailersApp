using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RetailersApp
{
    public partial class ProductInvoicePage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true)
            {
                SqlConnection connection = new SqlConnection(cn);
                string qry = "select ITEM_CODE from ITEM_TABLE";
                SqlCommand command = new SqlCommand(qry, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                List<string> Items = new List<string>();
                while (dataReader.Read())
                {
                    Items.Add(dataReader["ITEM_CODE"].ToString());

                }
                dataReader.Close();

                ddlItems.DataSource = Items;
                ddlItems.DataBind();
                connection.Close();




            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string CName = tbname.Text;
            String ICode = ddlItems.SelectedValue;
            string IModel = tbIModel.Text;
            String BatchNo = tbBatch.Text;
            string MDate = tbMDate.Text;
            string EDate = tbEDate.Text;
            int Qty = Convert.ToInt32(tbQty.Text);
            int Rate = Convert.ToInt32(tbrate.Text);
            int TAmount = Qty * Rate;

            //
            SqlConnection Connection = new SqlConnection(cn);
            String Qry = $"insert into ITEM_STOCK(CUSTOMER_NAME, ITEM_CODE, ITEM_MODEL, BATCH_NO, MFG_DATE, EXP_DATE, QUANTITY, RATE, TOTALAMOUNT) values('{CName}','{ICode}', '{IModel}', '{BatchNo}', '{MDate}', '{EDate}',{Qty},{Rate},{TAmount})";
            SqlCommand command = new SqlCommand(Qry, Connection);
            Connection.Open();
            int InsertedRows = command.ExecuteNonQuery();
            if (InsertedRows > 0)
            {
                Response.Output.WriteLine($"ItemNo={ICode} inserted sucessfully");
            }
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }

        }
    }
}