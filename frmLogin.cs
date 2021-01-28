using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             frmSetup obj = new frmSetup();
             obj.Closed += (s, args) => this.Close();
             obj.Show();*/

            //Connection String
            if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                try
                {
                    //Create SqlConnection
                    
                    SqlCommand cmd = new SqlCommand("Select * from tblSetup where OwnerName=@OwnerName and CreatePassword=@CreatePassword", con);
                    cmd.Parameters.AddWithValue("@OwnerName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@CreatePassword", txtPassword.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        frmSetup fm = new frmSetup();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
