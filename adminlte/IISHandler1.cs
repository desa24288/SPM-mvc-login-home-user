using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace adminlte
{
    public partial class Login : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=192.168.45.128,49170;Initial Catalog=SPM_T;Persist Security Info=True;User ID=sa;Password=Spm2019!";
            con.Open();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           // cmd.CommandText = "select * from usuario where email='"+txtEmail+"' and password='"+txtPassword+"' ";
        }
    }
}
