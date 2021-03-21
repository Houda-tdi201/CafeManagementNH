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
    public partial class Order : Form
    {
        private string _un;
        public Order()
        {
            InitializeComponent();
        }
        public Order(string userN)
        {
            InitializeComponent();
            _un = userN;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Hello " + _un + " !";

            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("select * from categories", cn);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                cbCat.Items.Add(dr["catName"]);
                listBox2.Items.Add(dr["IdCat"]);
            }

            cbCat.SelectedIndex = 0;
            if (cbCat.SelectedIndex == -1)
                cbCat.SelectedIndex = 0;

            dr.Close();
            dr = null;

            
            SqlCommand com1 = new SqlCommand("Select IdUser from Users where userName=@Nuser", cn);
            com1.Parameters.AddWithValue("@Nuser", _un);
            lblIdUser.Text = com1.ExecuteScalar().ToString();

            btnAddorders.Visible = true;
            btnDeleteOrder.Visible = false;
            panel2.Enabled = false;
            dgAddedItems.Columns["IdOrder"].Visible = false;
            dgAddedItems.Columns["IdItem"].Visible = false;
            btnEditOrder.Visible = true;
            btnvalidateEditItem.Visible = false;
            btnCancelItem.Visible = false;
            btnAddCard.Enabled = true;


            cn.Close();
            cn = null;
            cs = null;
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox2.SelectedIndex = cbCat.SelectedIndex;
                string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                SqlCommand com = new SqlCommand("select IdItem,itemName,description, priceItem from items where IdCat=@idc", cn);
                com.Parameters.AddWithValue("@idc", listBox2.Text);
                SqlDataReader dr = com.ExecuteReader();
                dgShowItems.Rows.Clear();
                while (dr.Read())
                {
                    dgShowItems.Rows.Add(dr["IdItem"], dr["itemName"], dr["description"], dr["priceItem"]);
                }
                dgShowItems.Columns["idItems"].Visible = false;

                dr.Close();
                dr = null;

                cn.Close();
                cn = null;
                cs = null;
            }
            catch { }
        }

        private void refrechdgShow()
        {
            listBox2.SelectedIndex = cbCat.SelectedIndex;
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com = new SqlCommand("select IdItem,itemName,description, priceItem from items where IdCat=@idc and IdItem not in (select IdItem from addOrder where IdOrder=@ido)", cn);
            com.Parameters.AddWithValue("@idc", listBox2.Text);
            com.Parameters.AddWithValue("@ido", dgAddedItems.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader dr = com.ExecuteReader();
            dgShowItems.Rows.Clear();
            while (dr.Read())
            {
                dgShowItems.Rows.Add(dr["IdItem"], dr["itemName"], dr["description"], dr["priceItem"]);
            }
            dgShowItems.Columns["idItems"].Visible = false;

            dr.Close();
            dr = null;

            cn.Close();
            cn = null;
            cs = null;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddorders_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comInsert = new SqlCommand("insert into orders values(@date,@id)", cn);
            comInsert.Parameters.AddWithValue("@date", DateTime.Today.ToString());
            comInsert.Parameters.AddWithValue("@id", lblIdUser.Text);
            comInsert.ExecuteNonQuery();

            SqlCommand com = new SqlCommand("select * from orders", cn);
            SqlDataReader dr = com.ExecuteReader();
            listBox1.Items.Clear();
            while(dr.Read())
            {
                listBox1.Items.Add(dr["IdOrder"]);
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            lblIdOrder.Text = listBox1.Text;
            btnAddorders.Visible = false;
            btnDeleteOrder.Visible = true;
            panel2.Enabled = true;
            

            dr.Close();
            dr = null;

            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comDelete = new SqlCommand("delete from orders where IdOrder=@id", cn);
            comDelete.Parameters.AddWithValue("@id", lblIdOrder.Text);
            comDelete.ExecuteNonQuery();

            dgShowItems.Rows.Clear();
            dgAddedItems.Rows.Clear();
            numQte.Value = 1;
            lblTotal.Text = "....";

            btnAddorders.Visible = true;
            btnDeleteOrder.Visible = false;
            lblIdOrder.Text = "....";
            panel2.Enabled = false;

            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (dgShowItems.CurrentRow != null)
            {
                string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();

                SqlCommand com1 = new SqlCommand("insert into addOrder values(@idOrder,@IdItems,@Qte,@price)", cn);
                com1.Parameters.AddWithValue("@idOrder",lblIdOrder.Text);
                com1.Parameters.AddWithValue("@IdItems", dgShowItems.CurrentRow.Cells[0].Value.ToString());
                com1.Parameters.AddWithValue("@Qte", numQte.Value.ToString());
                com1.Parameters.AddWithValue("@price", dgShowItems.CurrentRow.Cells[3].Value.ToString());
                com1.ExecuteNonQuery();

                SqlCommand comAddOrder = new SqlCommand("select IdOrder,a.IdItem,itemName,Qte,price,(Qte*price) as total from addOrder a inner join items i on a.IdItem = i.IdItem where IdOrder = @id", cn);
                comAddOrder.Parameters.AddWithValue("@id", lblIdOrder.Text);
                SqlDataReader dr1 = comAddOrder.ExecuteReader();
                dgAddedItems.Rows.Clear();
                while (dr1.Read())
                {
                    dgAddedItems.Rows.Add(dr1["IdOrder"], dr1["IdItem"], dr1["itemName"], dr1["Qte"], dr1["price"], dr1["total"]);
                }
                dgAddedItems.Columns["IdOrder"].Visible = false;
                dgAddedItems.Columns["IdItem"].Visible = false;
              
                dr1.Close();
                dr1 = null;

                SqlCommand com = new SqlCommand("select IdOrder,SUM(Qte*price)as total from addOrder where IdOrder=@id group by IdOrder", cn);
                com.Parameters.AddWithValue("@id", lblIdOrder.Text);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lblTotal.Text = dr["total"].ToString();
                }

                refrechdgShow();
                dr.Close();
                dr = null;
                cn.Close();
                cn = null;
                cs = null;
            }
            else
                MessageBox.Show("Choose an item to Add!");
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgAddedItems.CurrentRow != null)
            {
                numQte.Focus();
                dgAddedItems.CurrentCell = dgAddedItems.CurrentRow.Cells[3];
                btnEditOrder.Visible = false;
                btnvalidateEditItem.Visible = true;
                btnCancelItem.Visible = true;
                btnAddCard.Enabled = false;
            }
            else
                MessageBox.Show("Choose an item to edit!");
        }

        private void refrechDgAdd()
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand comAddOrder = new SqlCommand("select IdOrder,a.IdItem,itemName,Qte,price,(Qte*price) as total from addOrder a inner join items i on a.IdItem = i.IdItem where IdOrder = @id", cn);
            comAddOrder.Parameters.AddWithValue("@id", lblIdOrder.Text);
            SqlDataReader dr1 = comAddOrder.ExecuteReader();
            dgAddedItems.Rows.Clear();
            while (dr1.Read())
            {
                dgAddedItems.Rows.Add(dr1["IdOrder"], dr1["IdItem"], dr1["itemName"], dr1["Qte"], dr1["price"], dr1["total"]);
            }
            dgAddedItems.Columns["IdOrder"].Visible = false;
            dgAddedItems.Columns["IdItem"].Visible = false;

            dr1.Close();
            dr1 = null;

            SqlCommand com = new SqlCommand("select IdOrder,SUM(Qte*price)as total from addOrder where IdOrder=@id group by IdOrder", cn);
            com.Parameters.AddWithValue("@id", lblIdOrder.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblTotal.Text = dr["total"].ToString();
            }
            dr.Close();
            dr = null;
            cn.Close();
            cn = null;
            cs = null;
        }

        private void btnvalidateEditItem_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand com1 = new SqlCommand("update addOrder set Qte=@qte where IdOrder=@ido and IdItem=@idi", cn);
            com1.Parameters.AddWithValue("@ido", dgAddedItems.CurrentRow.Cells[0].Value.ToString());
            com1.Parameters.AddWithValue("@idi", dgAddedItems.CurrentRow.Cells[1].Value.ToString());
            com1.Parameters.AddWithValue("@qte", numQte.Value.ToString());
            com1.ExecuteNonQuery();
            refrechDgAdd();
            cn.Close();
            cn = null;
            cs = null;

            btnEditOrder.Visible = true;
            btnvalidateEditItem.Visible = false;
            btnCancelItem.Visible = false;
            btnAddCard.Enabled = true;
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            btnEditOrder.Visible = true;
            btnvalidateEditItem.Visible = false;
            btnCancelItem.Visible = false;
            btnAddCard.Enabled = true;
            numQte.Value = 1;
            dgAddedItems.CurrentCell = dgAddedItems.CurrentRow.Cells[2];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgAddedItems.Rows != null)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
                MessageBox.Show("you have not choose any items yet!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
                e.Graphics.DrawString("==========Friendship Cafe==========", new Font("Script MT", 20, FontStyle.Bold), Brushes.Red, new Point(120, 40));
                e.Graphics.DrawString("----------Order Summary----------", new Font("Script MT", 20, FontStyle.Bold), Brushes.Red, new Point(185, 70));
                e.Graphics.DrawString("Order Number: " + lblIdOrder.Text, new Font("Script MT", 18, FontStyle.Regular), Brushes.Brown, new Point(120, 115));
                int p = 145;
                for (int i = 0; i < dgAddedItems.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dgAddedItems.Rows[i].Cells[2].Value.ToString() + " *" + dgAddedItems.Rows[i].Cells[3].Value.ToString() + " ----------------" + dgAddedItems.Rows[i].Cells[5].Value.ToString() + " DH", new Font("Script MT", 14, FontStyle.Regular), Brushes.Black, new Point(120, p));
                    p += 35;
                }
                e.Graphics.DrawString("          Total: " + lblTotal.Text + " DH", new Font("Script MT", 18, FontStyle.Bold), Brushes.Brown, new Point(160, p+20));
            
            
        }
    }
}
