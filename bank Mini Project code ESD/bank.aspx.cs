using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class bank : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txt_acc_no.Text == "")
        {
            Label1.Text = "Enter Account Number";
        }
        else 
        {
             int acno = Convert.ToInt32(txt_acc_no.Text);
             DataSet ds1 = (DataSet)BLogic.AccountInfo(acno);
                
                if (ds1.Tables[0].Rows.Count > 0)
                {

                     DataRow dr = ds1.Tables[0].Rows[0];

                    txt_Cust_Name.Text = dr["CustName"].ToString();
                    txt_Acc_type.Text = dr["AcntTypeName"].ToString();
                    txt_Bal.Text = dr["Balance"].ToString();

                 }
                 else
                {
                     Label1.Text = "No Record Found At Account Number " + acno; 
                }

        }

    }
}