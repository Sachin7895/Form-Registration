using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace web1
{
    public partial class gridView : System.Web.UI.Page

    {

        SqlConnection con = new SqlConnection("Data Source =DESKTOP-R49R8OH; Initial Catalog = Student;user Id=sa;password= s");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source =DESKTOP-R49R8OH; Initial Catalog = Student;user Id=sa;password= s");
               
                this.BindGrid();
            }
        }

        public void BindGrid()

        {

            con.Open();
            System.Diagnostics.Debug.WriteLine("Dsd");
            SqlCommand cmd = new SqlCommand("select SNo,Name,Class,Dob,Gender,State from Registrations where visible=1");
            cmd.Connection = con;
            SqlDataAdapter sd = new SqlDataAdapter();
            sd.SelectCommand = cmd;

            DataTable ds = new DataTable();

            sd.Fill(ds);

            gridView1.DataSource = ds;
            gridView1.DataBind();
            ViewState["dt"] = ds;

            gridView1.DataSource = ViewState["dt"] as DataTable;
            gridView1.DataBind();

        }

        protected void GridViewEditing(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Dsd");


            Response.Redirect("WebForm1.aspx");

        }



        protected void OnGetDetails(object sender, EventArgs e)
        {
            Debug.WriteLine("Dsd");
            GridViewRow row = ((sender as Button).NamingContainer as GridViewRow);
            string SNo = row.Cells[0].Text;

            string Name = row.Cells[1].Text;
            string Class = row.Cells[2].Text;
            string Dob = row.Cells[3].Text;
            string Gender = row.Cells[4].Text;
            string State = row.Cells[5].Text;
            Debug.WriteLine(SNo);
            Debug.WriteLine(Name);




            Response.Redirect("Webform1.aspx?SNo=" + SNo + "&Name=" + Name + "&Class=" + Class + "&Dob=" + Dob + "&Gender=" + Gender + "&State=" + State);





        }




        protected void gridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string name = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "name"));
                Button bTn = (Button)e.Row.FindControl("button2");
                bTn.Attributes.Add("onClick", "javascript:return ConfirmationBox('" + name + "')");
            }
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {

            con.Open();
            GridViewRow gvrow = ((sender as Button).NamingContainer as GridViewRow);

            int SNoo = Convert.ToInt32(gridView1.DataKeys[gvrow.RowIndex].Value.ToString());
            Debug.WriteLine(Convert.ToInt32(gridView1.DataKeys[gvrow.RowIndex].Value.ToString()));
            Debug.WriteLine(SNoo);

            
            System.Diagnostics.Debug.WriteLine("Dsd");
            SqlCommand cmd = new SqlCommand("update Registrations set visible=0 where SNo=@roll", con);
            cmd.Parameters.AddWithValue("@roll",SNoo);
            GridViewRow row = ((sender as Button).NamingContainer as GridViewRow);

         




            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("select SNo,Name,Class,Dob,Gender,State from Registrations where visible=1",con);

            cmd1.ExecuteNonQuery();

            SqlDataAdapter sd = new SqlDataAdapter();
            sd.SelectCommand = cmd1;

            DataTable ds = new DataTable();

            sd.Fill(ds);

            gridView1.DataSource = ds;
            gridView1.DataBind();
            


        }

    
      
    }
}