using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{


    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ToString());

    public void clear()
    {
    
        txt_studentname.Text = "";
        txt_DOB.Text = "";
        ddlCity.SelectedValue = null;
        Rad_dotnet.Checked = false;
        Rad_java.Checked = false;
        Check_XML.Checked = false;
        Check_javascript.Checked = false;
        Check_HTML.Checked = false;
        Check_Security.Checked = false;


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void But_AddEnRoll_Click(object sender, EventArgs e)
    {
        if (Rad_dotnet.Checked == true)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Student (StudentName,DOB,CityId,Stream,Op_sub_XML,Op_sub_Javascript,Op_sub_HTML,op_sub_Security)values (@SName,@DOB,@CityId,@Stream,@Xml,@JavaScript,@HTML,@Security)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@SName", txt_studentname.Text);
            cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text.ToString());
            cmd.Parameters.AddWithValue("@CityId", ddlCity.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Stream", Rad_dotnet.Text);
            cmd.Parameters.AddWithValue("@Xml", Check_XML.Checked);
            cmd.Parameters.AddWithValue("@JavaScript", Check_javascript.Checked);
            cmd.Parameters.AddWithValue("@HTML", Check_HTML.Checked);
            cmd.Parameters.AddWithValue("@Security", Check_Security.Checked);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            Lab_msg.Text ="Student  Added successfully with  Dot Net .....";
          
        }
        else if (Rad_java.Checked == true)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Student (StudentName,DOB,CityId,Stream,Op_sub_XML,Op_sub_Javascript,Op_sub_HTML,op_sub_Security)values (@SName,@DOB,@CityId,@Stream,@Xml,@JavaScript,@HTML,@Security)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@SName", txt_studentname.Text);
            cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text.ToString());
            cmd.Parameters.AddWithValue("@CityId", ddlCity.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Stream", Rad_java.Text);
            cmd.Parameters.AddWithValue("@Xml", Check_XML.Checked);
            cmd.Parameters.AddWithValue("@JavaScript", Check_javascript.Checked);
            cmd.Parameters.AddWithValue("@HTML", Check_HTML.Checked);
            cmd.Parameters.AddWithValue("@Security", Check_Security.Checked);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            Lab_msg.Text = "Student  Added successfully with  Java .....";
            clear();

         }

        else if (Rad_Non.Checked == true)
        {
            Lab_msg.Text = "Please Select One Technology";

        }

    }
   
    protected void Check_Non_CheckedChanged(object sender, EventArgs e)
    {
        Lab_msg.Text = "Please select Any one technology   Dot Net  or  Java";
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
    
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        txt_DOB.Text = Calendar1.SelectedDate.ToString();
    }
}