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
    public partial class ViewOrder : Form
    {
        private string _un;

        public ViewOrder()
        {
            InitializeComponent();
        }
        public ViewOrder(string username)
        {
            InitializeComponent();
            _un = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            lblUsername.Text = _un;

            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("Select IdUser from Users where UserName=@u",cn);
            com.Parameters.AddWithValue("@u", _un);
            lblIdUser.Text= com.ExecuteScalar().ToString();

            SqlCommand com2 = new SqlCommand("Select * from orders where IdUser= @id", cn);
            com2.Parameters.AddWithValue("@id", lblIdUser.Text);
            SqlDataReader dr = com2.ExecuteReader();
            dgOrders.Rows.Clear();
            while(dr.Read())
            {
                dgOrders.Rows.Add(dr["IdOrder"], dr["DateOrder"]);
            }
            dr.Close();
            dr = null;
            cn.Close();
            cn = null;
            cs = null;

            dgItems.Enabled = false;
        }

        private void dgOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand comAddOrder = new SqlCommand("select IdOrder as code,a.IdItem,itemName,Qte,price,(Qte*price) as total from addOrder a inner join items i on a.IdItem = i.IdItem where IdOrder = @id", cn);
            comAddOrder.Parameters.AddWithValue("@id", dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            SqlDataReader dr1 = comAddOrder.ExecuteReader();
            dgItems.Rows.Clear();
            while (dr1.Read())
            {
                dgItems.Rows.Add(dr1["code"], dr1["IdItem"], dr1["itemName"], dr1["Qte"], dr1["price"], dr1["total"]);
            }
            dgItems.Columns["codeId"].Visible = false;
            dgItems.Columns["IdItem"].Visible = false;
            

            dr1.Close();
            dr1 = null;
            if (dgItems.Rows != null)
            {

                SqlCommand com = new SqlCommand("select IdOrder,SUM(Qte*price)as total from addOrder where IdOrder=@id group by IdOrder", cn);
                com.Parameters.AddWithValue("@id", dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lblTotal.Text = dr["total"].ToString();
                }
                dr.Close();
                dr = null;
            }
            else
                lblTotal.Text = "....";
            cn.Close();
            cn = null;
            cs = null;
        }

        private void dgOrders_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgItems.Rows.Clear();
        }
    }
}
