using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace RetailersApp
{
    public partial class HomePage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductRegistrationPage.aspx");
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }

        protected void btnOrderItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductInvoicePage.aspx");

        }

        protected void btnEditItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProductInvoicePage.aspx");
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(cn))
            {
                String qry = "Select * from ITEM_STOCK";
                using (SqlCommand command = new SqlCommand(qry, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        //creating list for catching group of values from database
                        List<Item> ITEMS = new List<Item>();
                        while (dr.Read())
                        {
                            //create a class object which will store every column details in it
                            Item items = new Item();
                            items.SEQ_NO = dr["SEQ_NO"].ToString();
                            items.CUSTOMER_NAME = dr["CUSTOMER_NAME"].ToString();
                            items.ITEM_CODE = dr["ITEM_CODE"].ToString();
                            items.ITEM_MODEL = dr["ITEM_MODEL"].ToString();
                            items.BATCH_NO = dr["BATCH_NO"].ToString();
                            items.MFG_DATE = dr["MFG_DATE"].ToString();
                            items.EXP_DATE = dr["EXP_DATE"].ToString();
                            items.QUANTITY = Convert.ToInt32(dr["QUANTITY"]);
                            items.PRICE = Convert.ToInt32(dr["RATE"]);
                            //
                            items.TOTAL_AMOUNT = (Convert.ToInt32(dr["QUANTITY"]) * Convert.ToInt32(dr["RATE"]));
                            //items.TOTAL_AMOUNT = Convert.ToInt64(dr["RATE"]);
                            ITEMS.Add(items);
                        }
                        dr.Close();
                        grdvDisplay.DataSource = ITEMS;
                        grdvDisplay.DataBind();
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

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Response.Redirect("RemoveProductPage.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(cn))
            {
                string itemCode = tbItem.Text;
                String qry = $"Select ITEM_NAME from ITEM_TABLE where ITEM_CODE ='{itemCode}'";
                using (SqlCommand command = new SqlCommand(qry, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        String ModelName = string.Empty;
                        while (dr.Read())
                        {
                            ModelName += dr["ITEM_NAME"].ToString();
                        }
                        dr.Close();
                        lblDisplay.Text = ModelName;
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

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLoginPage.aspx");
        }
    }
    public class Item
    {
        public string SEQ_NO { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_MODEL { get; set; }
        public string BATCH_NO { get; set; }
        public string MFG_DATE { get; set; }
        public string EXP_DATE { get; set; }
        public int QUANTITY { get; set; }
        public int PRICE { get; set; }
        public long TOTAL_AMOUNT { get; set; }
    }
}