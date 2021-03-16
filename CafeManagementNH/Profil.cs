using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CafeManagementNH
{
    public partial class Profil : Form
    {
        private string _userN;

        public Profil()
        {
            InitializeComponent();
        }
        public Profil(string username)
        {
            InitializeComponent();
            _userN = username;
        }

       

        private void Profil_Load(object sender, EventArgs e)
        {
        
            lblUser.Text = "User Name :" + _userN;

            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string qry = "select * from Users where UserName=@UN";
            SqlCommand com = new SqlCommand(qry, cn);
            com.Parameters.AddWithValue("@UN", _userN);
            SqlDataReader dr = com.ExecuteReader();

            while(dr.Read())
            {
                txtFN.Text = dr["FirstName"].ToString();
                txtLN.Text = dr["LastName"].ToString();
                txtPass.Text = dr["password"].ToString();
                txtAdr.Text = dr["adresse"].ToString();
                txtEmali.Text = dr["Email"].ToString();
                txtTel.Text = dr["Tel"].ToString();
            }
            dr.Close();
            dr = null;

            cn.Close();
            cn = null;
            com = null;

            activate(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activate(false);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string qry = "update Users set FirstName=@fn,LastName=@ln,password=@ps,adresse=@adr,email=@em,tel=@tel where UserName=@UN";
            SqlCommand com = new SqlCommand(qry, cn);
            com.Parameters.AddWithValue("@fn",txtFN.Text);
            com.Parameters.AddWithValue("@ln",txtLN.Text);
            com.Parameters.AddWithValue("@ps",txtPass.Text);
            com.Parameters.AddWithValue("@adr",txtAdr.Text);
            com.Parameters.AddWithValue("@em",txtEmali.Text);
            com.Parameters.AddWithValue("@tel",txtTel.Text);
            com.Parameters.AddWithValue("@UN", _userN);

            com.ExecuteNonQuery();

            MessageBox.Show("Update with success!");

            activate(true);
            cn.Close();
            cn = null;
            com = null;
        }

        private void activate(Boolean v)
        {
           
            btndelete.Visible = v;
            btnEdit.Visible = v;

            
            btnValidate.Visible = !v;
            panel1.Enabled = !v;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete your account?","delete Account",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string qry = "delete from Users where UserName=@UN";
                SqlCommand com = new SqlCommand(qry, cn);
                com.Parameters.AddWithValue("@UN", _userN);
                com.ExecuteNonQuery();

                MessageBox.Show("delete with success!");


                cn.Close();
                cn = null;
                com = null;

                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Close();
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientPage c = new ClientPage(_userN);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}
