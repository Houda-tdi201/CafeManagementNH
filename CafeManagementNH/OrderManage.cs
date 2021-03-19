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
    public partial class OrderManage : Form
    {
        public OrderManage()
        {
            InitializeComponent();
        }
        

        private void OrderManage_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comClient = new SqlCommand("Select * from Users", cn);
            SqlDataReader dr = comClient.ExecuteReader();

            cbClient.Items.Clear();
            listBox1.Items.Clear();
            while(dr.Read())
            {
                cbClient.Items.Add(dr["UserName"]);
                listBox1.Items.Add(dr["IdUser"]);
            }

            cbClient.SelectedIndex = 0;
            if (cbClient.SelectedIndex == -1)
                cbClient.SelectedIndex = 0;

            dr.Close();
            dr = null;

            panelEdit.Location = new Point(panelAdd.Location.X, panelAdd.Location.Y);
            //addOrEdit(true);
            panelAdd.Visible = true;
            panelEdit.Visible = false;
            btnvalidateEditItem.Visible = false;
            dgAddOrders.Enabled = true;

            activate(true);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrechDgOrder();
                
        }

        private void refrechDgOrder()
        {
            listBox1.SelectedIndex = cbClient.SelectedIndex;
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comOrder = new SqlCommand("select * from orders where IdUser = @id", cn);
            comOrder.Parameters.AddWithValue("@id", listBox1.Text);
            SqlDataReader dr = comOrder.ExecuteReader();

            dgOrders.Rows.Clear();
            while (dr.Read())
            {
                dgOrders.Rows.Add(dr["IdOrder"], dr["DateOrder"]);
            }
            dr.Close();
            dr = null;

           
            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comInsert = new SqlCommand("insert into orders values(@date,@id)", cn);
            comInsert.Parameters.AddWithValue("@date", DateTime.Today.ToString());
            comInsert.Parameters.AddWithValue("@id", listBox1.Text);
            comInsert.ExecuteNonQuery();

            refrechDgOrder();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgOrders.CurrentRow != null)
            {
                if (MessageBox.Show("are you sure you want to delete this order?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    SqlCommand comDelet = new SqlCommand("delete from orders where IdOrder=@id", cn);
                    comDelet.Parameters.AddWithValue("@id", dgOrders.CurrentRow.Cells[0].Value.ToString());
                    comDelet.ExecuteNonQuery();

                    refrechDgOrder();
                }
            }
        }

       

        private void dgOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand comAddOrder = new SqlCommand("select IdOrder as code,a.IdItem,itemName,Qte,price,(Qte*price) as total from addOrder a inner join items i on a.IdItem = i.IdItem where IdOrder = @id", cn);
            comAddOrder.Parameters.AddWithValue("@id", dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            SqlDataReader dr1 = comAddOrder.ExecuteReader();
            dgAddOrders.Rows.Clear();
            while (dr1.Read())
            {
                dgAddOrders.Rows.Add(dr1["code"], dr1["IdItem"], dr1["itemName"], dr1["Qte"], dr1["price"], dr1["total"]);
            }
            dgAddOrders.Columns["code"].Visible = false;
            dgAddOrders.Columns["IdItem"].Visible = false;
            dgAddOrders.Columns["itemName"].HeaderText = "Item Name";
            dgAddOrders.Columns["total"].HeaderText = "Total";

            dr1.Close();
            dr1 = null;

            SqlCommand com = new SqlCommand("select IdOrder,SUM(Qte*price)as total from addOrder where IdOrder=@id group by IdOrder", cn);
            com.Parameters.AddWithValue("@id", dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                lblTotal.Text = "Total :" + dr["total"];
            }
            dr.Close();
            dr = null;
            cn.Close();
            cn = null;
            cs = null;
        }

        private void dgOrders_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgAddOrders.Rows.Clear();
        }

        private void activate(Boolean v)
        {
            btnAddItems.Visible = v;
            btnDeleteItems.Visible = v;
            btnEditItems.Visible = v;
            cbClient.Enabled = v;
            btnAddClient.Enabled = v;
            dgOrders.Enabled = v;
            btnAddOrder.Enabled = v;
            btnDeleteOrder.Enabled = v;
            dgAddOrders.Enabled = v;

            btnValidateItem.Visible = !v;
            btnCancelItem.Visible = !v;
            panelAdd.Enabled = !v;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            activate(false);

            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand comItem = new SqlCommand("select IdItem,itemName,priceItem from items where IdItem not in (select IdItem from addOrder where IdOrder=@id)", cn);
            comItem.Parameters.AddWithValue("@id", dgOrders.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader dr2 = comItem.ExecuteReader();
            cbItems.Items.Clear();
            lstIdItem.Items.Clear();
            while(dr2.Read())
            {
                cbItems.Items.Add(dr2["itemName"]);
                lstIdItem.Items.Add(dr2["IdItem"]);
            }
            dr2.Close();
            dr2 = null;

            cn.Close();
            cn = null;
            cs = null;
        }

        private void refrechDGaddorder()
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand comAddOrder = new SqlCommand("select IdOrder as code,a.IdItem,itemName,Qte,price,(Qte*price) as total from addOrder a inner join items i on a.IdItem = i.IdItem where IdOrder = @id", cn);
            comAddOrder.Parameters.AddWithValue("@id", dgOrders.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader dr1 = comAddOrder.ExecuteReader();
            dgAddOrders.Rows.Clear();
            while (dr1.Read())
            {
                dgAddOrders.Rows.Add(dr1["code"], dr1["IdItem"], dr1["itemName"], dr1["Qte"], dr1["price"], dr1["total"]);
            }
            dgAddOrders.Columns["code"].Visible = false;
            dgAddOrders.Columns["IdItem"].Visible = false;
            dgAddOrders.Columns["itemName"].HeaderText = "Item Name";
            dgAddOrders.Columns["total"].HeaderText = "Total";

            dr1.Close();
            dr1 = null;

            SqlCommand com = new SqlCommand("select IdOrder,SUM(Qte*price)as total from addOrder where IdOrder=@id group by IdOrder", cn);
            com.Parameters.AddWithValue("@id", dgOrders.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblTotal.Text = "Total :" + dr["total"].ToString();
            }
            dr.Close();
            dr = null;
            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnValidateItem_Click(object sender, EventArgs e)
        {
            activate(true);
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("insert into addOrder values(@idorder,@iditem,@qte,@price)",cn);
            com.Parameters.AddWithValue("@idorder", dgOrders.CurrentRow.Cells[0].Value.ToString());
            com.Parameters.AddWithValue("@iditem",lstIdItem.Text);
            com.Parameters.AddWithValue("@qte",numQte.Value.ToString());
            com.Parameters.AddWithValue("@price",txtPrice.Text);
            com.ExecuteNonQuery();
            refrechDGaddorder();
            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelAdd.Visible = true;
            btnvalidateEditItem.Visible = false;
            dgAddOrders.Enabled = true;

            activate(true);

            cbItems.SelectedIndex = -1;
            numQte.Value = 1;
            txtPrice.Text = "";
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            
            if (dgAddOrders.CurrentRow != null)
            {
                activate(false);

                btnValidateItem.Visible = false;
                panelAdd.Visible = false;
                panelEdit.Visible = true;
                btnvalidateEditItem.Visible = true;

                
                string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                SqlCommand com = new SqlCommand("select a.IdItem,itemName,Qte,price from addOrder a inner join items i on i.IdItem=a.IdItem where IdOrder=@ido and a.IdItem=@idi", cn);
                com.Parameters.AddWithValue("@ido",dgAddOrders.CurrentRow.Cells[0].Value.ToString());
                com.Parameters.AddWithValue("@idi",dgAddOrders.CurrentRow.Cells[1].Value.ToString());
                SqlDataReader dr = com.ExecuteReader();

                while(dr.Read())
                {
                    cbEditItem.Text = dr["itemName"].ToString();
                    numEditItem.Value = Convert.ToInt32(dr["Qte"]);
                    txtEditPrice.Text = dr["price"].ToString();
                }
                cbEditItem.Enabled = false;
                dr.Close();
                dr = null;
            }
        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            if (dgAddOrders.CurrentRow != null)
            {
                if (MessageBox.Show("are you sure you want to delete this item from this order?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    SqlCommand com = new SqlCommand("delete from addOrder where idOrder=@idO and idItem= @idi", cn);
                    com.Parameters.AddWithValue("@idO", dgAddOrders.CurrentRow.Cells[0].Value.ToString());
                    com.Parameters.AddWithValue("@idi", dgAddOrders.CurrentRow.Cells[1].Value.ToString());
                    com.ExecuteNonQuery();
                    refrechDGaddorder();
                    cn.Close();
                    cn = null;
                    cs = null;
                    com = null;
                }
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstIdItem.SelectedIndex = cbItems.SelectedIndex;
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand com = new SqlCommand("select IdItem,itemName,priceItem from items where IdItem=@id", cn);
            com.Parameters.AddWithValue("@id", lstIdItem.Text);
            SqlDataReader dr3 = com.ExecuteReader();

            while(dr3.Read())
            {
                txtPrice.Text = dr3["priceItem"].ToString();
            }
            dr3.Close();
            dr3 = null;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientManage c = new ClientManage();
            c.ShowDialog();

            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comClient = new SqlCommand("Select * from Users", cn);
            SqlDataReader dr = comClient.ExecuteReader();

            cbClient.Items.Clear();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                cbClient.Items.Add(dr["UserName"]);
                listBox1.Items.Add(dr["IdUser"]);
            }

            cbClient.SelectedIndex = 0;
            if (cbClient.SelectedIndex == -1)
                cbClient.SelectedIndex = 0;

            dr.Close();
            dr = null;
        }

        private void btnvalidateEditItem_Click(object sender, EventArgs e)
        {
            if (dgAddOrders.CurrentRow != null)
            {
                panelEdit.Visible = false;
                panelAdd.Visible = true;
                btnvalidateEditItem.Visible = false;
                activate(true);
                string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                SqlCommand com = new SqlCommand("update addOrder set Qte=@qte,price=@price where IdOrder=@ido and IdItem=@idi", cn);
                com.Parameters.AddWithValue("@ido", dgOrders.CurrentRow.Cells[0].Value.ToString());
                com.Parameters.AddWithValue("@idi", dgAddOrders.CurrentRow.Cells[1].Value.ToString());
                com.Parameters.AddWithValue("@qte", numEditItem.Value.ToString());
                com.Parameters.AddWithValue("@price", txtEditPrice.Text);
                com.ExecuteNonQuery();
                refrechDGaddorder();
                cn.Close();
                cn = null;
                cs = null;
            }
        }

       
    }
}
