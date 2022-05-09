using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Diagnostics;



namespace web1
{
    public partial class WebForm1 : System.Web.UI.Page


    {

        SqlConnection con = new SqlConnection("Data Source =DESKTOP-R49R8OH; Initial Catalog = Student;user Id=sa;password= s");
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!this.IsPostBack)
            {
                textBox3.Text = Request.QueryString["SNo"];
                textBox1.Text = Request.QueryString["Name"];
                DropDownList2.SelectedValue = Request.QueryString["Class"];
                textDate.Text = Request.QueryString["Dob"];
                radioButton1.SelectedValue = Request.QueryString["Gender"];
                DropDownList1.SelectedValue = Request.QueryString["State"];


            }

            
            
        }
    
        protected void Submit_Click(object sender, EventArgs e)
        {

           
            
           
                Debug.WriteLine(con);




            con.Open();

           
            SqlCommand cmd = new SqlCommand("insert into Registrations(name,class,dob,gender,state,SNo) values (@name, @class,@dob,@gender,@state,@roll)", con);
           
            cmd.Parameters.AddWithValue("name", textBox1.Text);
            cmd.Parameters.AddWithValue("class", DropDownList2.SelectedValue);
                cmd.Parameters.AddWithValue("dob",textDate.Text );
                cmd.Parameters.AddWithValue("gender", radioButton1.SelectedValue);
                cmd.Parameters.AddWithValue("state", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("roll", textBox3.Text);

            Debug.WriteLine(textDate.Text);

            submit.Visible = false;


            Button4.Visible = true;

           


            if (con.State==ConnectionState.Closed)
            {
                con.Open();

            }

            cmd.ExecuteNonQuery();
            con.Close();

            Reset_Click(sender,e);

            alert.Text = "Record Successfull Saved";
            alert.ForeColor = Color.Black;







        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            DropDownList2.SelectedValue = "";
            textBox3.Text = "";


            radioButton1.SelectedValue = "" ;
            DropDownList1.SelectedValue = "" ;
        }

        

        /* protected void ImageButtonCalendar_Click(object sender, ImageClickEventArgs e)
         {
             Calendar.Visible = true;
         }

         protected void Calendar_SelectionChanged(object sender, EventArgs e)
         {
             DateTime dt= Calendar.SelectedDate;
             textBox3.Text = dt.ToString("yyyy-mm-dd");
             Calendar.Visible = false;
         }
     }*/



        protected void Update_Click(object sender, EventArgs e)
       {




           con.Open();



            submit.Visible = false;
            Button2.Visible = true;
            Button3.Visible = false;

            
            
            SqlCommand cmd = new SqlCommand("update Registrations set Class=@class,Name=@name,Dob=@dob,Gender=@gender,State=@state where visible=1", con);


            
           cmd.Parameters.AddWithValue("roll", textBox3.Text);
           cmd.Parameters.AddWithValue("name", textBox1.Text);
           cmd.Parameters.AddWithValue("class", DropDownList2.SelectedValue);
           cmd.Parameters.AddWithValue("dob",textDate.Text);
           cmd.Parameters.AddWithValue("gender", radioButton1.SelectedValue);
           cmd.Parameters.AddWithValue("state", DropDownList1.SelectedValue);
           cmd.ExecuteNonQuery();
           con.Close();

            Reset_Click(sender, e);

            alert.Text = "Record Update Saved";
            alert.ForeColor = Color.Red;


        }

        protected void Select_Click(object sender, EventArgs e)
        {
            Response.Redirect("gridView.aspx");
        }


    }
}