using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;



public class BLogic
{
    SqlConnection cn = new SqlConnection("Data Source=SUDHINDRA-PC;Initial Catalog=Account;Integrated Security=True");
    SqlCommand cmd;

    public BLogic()
    {

    }

    public static DataSet AccountInfo(int AccountNo)
    {

        SqlConnection cn = new SqlConnection("Data Source=IMRAN-PC;Initial Catalog=shopDatabase;Integrated Security=True");
        SqlCommand cmd;
        cmd = new SqlCommand("ShowAccountDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ANO", SqlDbType.Int).Value = Convert.ToInt32(AccountNo);


        SqlDataAdapter adt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adt.Fill(ds, "Table[0]");



        return ds;







    }



}