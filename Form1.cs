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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da, da1;
        DataSet ds;
        //DataSet ds1;
        public Form1()
        {
            InitializeComponent();
        }
        // Variables Declartions***********************************************************
        private int xPos = 0, YPos = 0;
        private int i = 0,i2=0,i3=0,i4=0,i5=0,i6=0;
        private int t1 = 0;
        private int s, s1, s2, s3, s4, s5, s6;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblText.Text = "www.agami.com";
            xPos = lblText.Location.X;
            YPos = lblText.Location.Y;
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //i++;

            //lblStart.Text = i.ToString();
            //q = i * 10;
            //lblAmount.Text = q.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //i--;
            //lblStart.Text = i.ToString();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBr4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0020'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBreadName.Text = (myReader["ProductName"].ToString());
                lblBreadPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBr3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0019'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBreadName.Text = (myReader["ProductName"].ToString());
                lblBreadPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBr2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0018'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBreadName.Text = (myReader["ProductName"].ToString());
                lblBreadPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBr1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0017'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBiskitName.Text = (myReader["ProductName"].ToString());
                lblBiskitPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBP4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0016'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBiskitName.Text = (myReader["ProductName"].ToString());
                lblBiskitPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBP3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0015'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBiskitName.Text = (myReader["ProductName"].ToString());
                lblBiskitPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBP2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0014'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblBiskitName.Text = (myReader["ProductName"].ToString());
                lblBiskitPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnBP1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0013'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblChocoName.Text = (myReader["ProductName"].ToString());
                lblChocoPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnCP4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0012'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblChocoName.Text = (myReader["ProductName"].ToString());
                lblChocoPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnCP3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0011'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblChocoName.Text = (myReader["ProductName"].ToString());
                lblChocoPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnCP2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0010'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblChocoName.Text = (myReader["ProductName"].ToString());
                lblChocoPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnCP1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0009'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblChocoName.Text = (myReader["ProductName"].ToString());
                lblChocoPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnSP4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0008'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblNameSnacks.Text = (myReader["ProductName"].ToString());
                lblCost.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnSP3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0007'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblNameSnacks.Text = (myReader["ProductName"].ToString());
                lblCost.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnSP2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0006'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                label12.Text = (myReader["ProductName"].ToString());
                lblPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnSP1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0005'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                lblNameSnacks.Text = (myReader["ProductName"].ToString());
                lblCost.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnDP7_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0004'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                label12.Text = (myReader["ProductName"].ToString());
                lblPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnDP5_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0003'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                label12.Text = (myReader["ProductName"].ToString());
                lblPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void btnDP3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0002'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                label12.Text = (myReader["ProductName"].ToString());
                lblPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
      
        private void btnIncrementQuantity_Click(object sender, EventArgs e)
        {
            i++;
            txtQ.Text = i.ToString();
            

        }

        private void btnD2_Click_1(object sender, EventArgs e)
        {
            i2--;
            txtQ2.Text = i2.ToString();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            i--;
            txtQ.Text = i.ToString();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            i = 0;
            txtQ.Text = i.ToString();
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void btni2_Click(object sender, EventArgs e)
        {
            i2++;
            txtQ2.Text = i2.ToString();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            //lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            i2 = 0;
            txtQ.Text = i2.ToString();
        }

        private void btni3_Click(object sender, EventArgs e)
        {
            i3++;
            txtQ3.Text = i3.ToString();
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            i3--;
            txtQ3.Text = i3.ToString();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            i3 = 0;
            txtQ3.Text = i3.ToString();
        }

        private void btni4_Click(object sender, EventArgs e)
        {
            i4++;
            txtQ4.Text = i4.ToString();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            i4--;
            txtQ4.Text = i4.ToString();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            i4 = 0;
            txtQ4.Text = i4.ToString();
        }

        private void btni5_Click(object sender, EventArgs e)
        {
            i5++;
            txtQ5.Text = i5.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            t1 = i + i2 + i3 + i4 + i5 + i6;
            lblStart.Text = t1.ToString();
            //s = s1 + s2;
            s = i * 20 + i2 * 15 + i3 * 10 + i4 * 20 + i5 * 15 + i6 * 20;
            lblAmount.Text = s.ToString();

        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            i5--;
            txtQ5.Text = i5.ToString();
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            i5 = 0;
            txtQ5.Text = i5.ToString();
        }

        private void btni6_Click(object sender, EventArgs e)
        {
            i6++;
            txtQ6.Text = i6.ToString();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            i6--;
            txtQ6.Text = i6.ToString();
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            i6 = 0;
            txtQ6.Text = i6.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xPos == 0)
            {

                this.lblText.Location = new System.Drawing.Point(this.Width, YPos);
                xPos = this.Width;
            }
            else
            {
                this.lblText.Location = new System.Drawing.Point(xPos, YPos);
                xPos -= 2;
            }
        }

        private void btnDP1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPOS;Integrated Security=True;Pooling=False");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from tblDrinks where ProductId='P0001'", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                label12.Text = (myReader["ProductName"].ToString());
                lblPrice.Text = (myReader["Price"].ToString());
            }
            con.Close();
        }
    }
}
