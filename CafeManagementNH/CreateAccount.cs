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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string qry = "Select * from Users";
            SqlCommand com = new SqlCommand(qry, cn);
            SqlDataReader dr = com.ExecuteReader();

            //use the list methode
            List<CApropriete> ca = new List<CApropriete>();
            while (dr.Read())
            {
                CApropriete c = new CApropriete(Convert.ToInt32(dr["IdUser"]), Convert.ToString(dr["UserName"]));
                ca.Add(c);
            }
            dr.Close();
            dr = null;

            if (txt_Username.Text == "")
            {
                label10.Text = "Username is requird!";
            }
            else if (txt_pass.Text == "")
            {
                label11.Text = "Password is requird!";
            }
            else
            {
               
                for (int i = 0; i < ca.Count; i++)
                {
                    label10.Text = "";
                    label11.Text = "";
                    if (txt_Username.Text == ca[i].Username)
                    {
                        label10.Text = "This userName is already exist!";
                        txt_Username.Clear();
                        break;
                       
                    }
                    else
                    {
                        string qry2 = "insert into Users values(@fn,@ln,@UserName,@pass,@adr,@em,@tel)";
                        SqlCommand com2 = new SqlCommand(qry2, cn);
                        com2.Parameters.AddWithValue("@fn", txt_FName.Text);
                        com2.Parameters.AddWithValue("@ln", txtLName.Text);
                        com2.Parameters.AddWithValue("@UserName", txt_Username.Text);
                        com2.Parameters.AddWithValue("@pass", txt_pass.Text);
                        com2.Parameters.AddWithValue("@adr", txtAdress.Text);
                        com2.Parameters.AddWithValue("@em", txtEmail.Text);
                        com2.Parameters.AddWithValue("@tel", txt_tel.Text);

                        com2.ExecuteNonQuery();
                        MessageBox.Show("Add With Success!");
                        com2 = null;
                        cs = null;
                        cn.Close();
                        cn = null;
                        ca.Clear();
                        com = null;
                        this.Close();
                    }

                }
            }

            
            
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
