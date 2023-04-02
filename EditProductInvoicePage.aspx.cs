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
    public partial class EditProductInvoicePage : System.Web.UI.Page
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

        protected void btnDispaly_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(cn))
            {

                String BatchNo = tbBatch.Text;
                // int TAmount = Qty * Rate;
                String qry = $"Select * from ITEM_STOCK where BATCH_NO='{BatchNo}'";
                using (SqlCommand command = new SqlCommand(qry, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        //creating list for catching group of values from database
                        //  List<Item> ITEMS = new List<Item>();
                        while (dr.Read())
                        {
                            //create a class object which will store every column details in it
                            //  Item items = new Item();
                            // = dr["SEQ_NO"].ToString();
                            tbname.Text = dr["CUSTOMER_NAME"].ToString();
                            ddlItems.SelectedValue = dr["ITEM_CODE"].ToString();
                            tbIModel.Text = dr["ITEM_MODEL"].ToString();
                            //items.BATCH_NO = dr["BATCH_NO"].ToString();
                            tbMDate.Text = dr["MFG_DATE"].ToString();
                            tbEDate.Text = dr["EXP_DATE"].ToString();
                            tbQty.Text = dr["QUANTITY"].ToString();
                            tbrate.Text = dr["RATE"].ToString();
                        }
                        dr.Close();


                    }
                    finally
                    {
                        if (Connection.State == ConnectionState.Open)
                        {
                            Connection.Close();
                        }
                    }
                }
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
            // String Qry = $"insert into ITEM_STOCK(CUSTOMER_NAME, ITEM_CODE, ITEM_MODEL, BATCH_NO, MFG_DATE, EXP_DATE, QUANTITY, RATE, TOTALAMOUNT) values('{CName}','{ICode}', '{IModel}', '{BatchNo}', '{MDate}', '{EDate}',{Qty},{Rate},{TAmount})";
            string qry = $"update ITEM_STOCK set CUSTOMER_NAME='{CName}', ITEM_CODE='{ICode}', ITEM_MODEL='{IModel}', MFG_DATE='{MDate}', EXP_DATE='{EDate}', QUANTITY={Qty}, RATE={Rate}, TOTALAMOUNT={TAmount} where BATCH_NO='{BatchNo}'";
            SqlCommand command = new SqlCommand(qry, Connection);
            Connection.Open();
            int UpdatedRows = command.ExecuteNonQuery();
            if (UpdatedRows > 0)
            {
                Response.Output.WriteLine($"Batch no={BatchNo} Updated sucessfully");
            }
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }

        }
    }
}